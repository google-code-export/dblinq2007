﻿#region MIT license
// 
// Copyright (c) 2007-2008 Jiri Moudry
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using DbLinq.Factory;
using DbLinq.Linq.Data.Sugar.ExpressionMutator;
using DbLinq.Linq.Data.Sugar.Expressions;

namespace DbLinq.Linq.Data.Sugar.Implementation
{
    public partial class ExpressionDispatcher : IExpressionDispatcher
    {
        public IExpressionQualifier ExpressionQualifier { get; set; }
        public IDataRecordReader DataRecordReader { get; set; }
        public IDataMapper DataMapper { get; set; }

        public ExpressionDispatcher()
        {
            ExpressionQualifier = ObjectFactory.Get<IExpressionQualifier>();
            DataRecordReader = ObjectFactory.Get<IDataRecordReader>();
            DataMapper = ObjectFactory.Get<IDataMapper>();
        }

        /// <summary>
        /// Registers the first table. Extracts the table type and registeres the piece
        /// </summary>
        /// <param name="requestingExpression"></param>
        /// <param name="builderContext"></param>
        /// <returns></returns>
        public virtual Expression CreateTableExpression(Expression requestingExpression, BuilderContext builderContext)
        {
            var callExpression = (MethodCallExpression)requestingExpression;
            var requestingType = callExpression.Arguments[0].Type;
            return CreateTable(GetQueriedType(requestingType), builderContext);
        }

        /// <summary>
        /// Registers the first table. Extracts the table type and registeres the piece
        /// </summary>
        /// <param name="requestingExpression"></param>
        /// <param name="builderContext"></param>
        /// <returns></returns>
        public virtual Expression GetTable(Expression requestingExpression, BuilderContext builderContext)
        {
            var callExpression = (MethodCallExpression)requestingExpression;
            var requestingType = callExpression.Arguments[0].Type;
            return CreateTable(GetQueriedType(requestingType), builderContext);
        }

        /// <summary>
        /// Builds the upper select clause
        /// </summary>
        /// <param name="selectExpression"></param>
        /// <param name="builderContext"></param>
        public virtual void BuildSelect(Expression selectExpression, BuilderContext builderContext)
        {
            // collect columns, split Expression in
            // - things we will do in CLR
            // - things we will do in SQL
            var lambdaSelectExpression = CutOutOperands(selectExpression, builderContext);
            // look for tables and use columns instead
            // (this is done after cut, because the part that went to SQL must not be converted)
            //selectExpression = selectExpression.Recurse(e => CheckTableExpression(e, builderContext));
            // the last return value becomes the select, with CurrentScope
            builderContext.CurrentScope.Select = lambdaSelectExpression;
            builderContext.ExpressionQuery.Select = builderContext.CurrentScope;
        }

        /// <summary>
        /// Cuts Expressions between CLR and SQL:
        /// - Replaces Expressions moved to SQL by calls to DataRecord values reader
        /// - SQL expressions are placed into Operands
        /// - Return value creator is the returned Expression
        /// </summary>
        /// <param name="selectExpression"></param>
        /// <param name="builderContext"></param>
        protected virtual LambdaExpression CutOutOperands(Expression selectExpression, BuilderContext builderContext)
        {
            var dataRecordParameter = Expression.Parameter(typeof(IDataRecord), "dataRecord");
            var mappingContextParameter = Expression.Parameter(typeof(MappingContext), "mappingContext");
            var expression = CutOutOperands(selectExpression, dataRecordParameter, mappingContextParameter, builderContext);
            return Expression.Lambda(expression, dataRecordParameter, mappingContextParameter);
        }

        /// <summary>
        /// Cuts tiers in CLR / SQL.
        /// The search for cut is top-down
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="dataRecordParameter"></param>
        /// <param name="mappingContextParameter"></param>
        /// <param name="builderContext"></param>
        /// <returns></returns>
        protected virtual Expression CutOutOperands(Expression expression,
            ParameterExpression dataRecordParameter, ParameterExpression mappingContextParameter,
            BuilderContext builderContext)
        {
            // two options: we cut and return
            if (GetCutOutOperand(expression, builderContext))
            {
                // before cutting out, we check that we're not cutting a table
                // in this case, we convert it into its declared columns
                if (expression is TableExpression)
                {
                    return RegisterParameterTable((TableExpression)expression, dataRecordParameter,
                                                  mappingContextParameter, builderContext);
                }
                // then, the result is registered
                return RegisterParameterColumnInvoke(expression, dataRecordParameter, mappingContextParameter, builderContext);
            }
            // or we dig down
            var operands = new List<Expression>();
            foreach (var operand in expression.GetOperands())
            {
                operands.Add(CutOutOperands(operand, dataRecordParameter, mappingContextParameter, builderContext));
            }
            return expression.ChangeOperands(operands);
        }

        /// <summary>
        /// Returns true if we must cut out the given Expression
        /// </summary>
        /// <param name="operand"></param>
        /// <param name="builderContext"></param>
        /// <returns></returns>
        private bool GetCutOutOperand(Expression operand, BuilderContext builderContext)
        {
            bool cutOut = false;
            var tier = ExpressionQualifier.GetTier(operand);
            if ((tier & ExpressionTier.Sql) != 0) // we can cut out only if the following expressiong can go to SQL
            {
                // then we have two possible strategies, load the DB at max, then it's always true from here
                if (builderContext.QueryContext.MaximumDatabaseLoad)
                    cutOut = true;
                else // if no max database load then it's min: we switch to SQL only when CLR doesn't support the Expression
                    cutOut = (tier & ExpressionTier.Clr) == 0;
            }
            return cutOut;
        }

        /// <summary>
        /// Checks any expression for a TableExpression, and eventually replaces it with the convenient columns selection
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="builderContext"></param>
        /// <returns></returns>
        protected virtual Expression CheckTableExpression(Expression expression, BuilderContext builderContext)
        {
            if (expression is TableExpression)
                return GetSelectTableExpression((TableExpression)expression, builderContext);
            return expression;
        }

        /// <summary>
        /// Replaces a table selection by a selection of all mapped columns (ColumnExpressions).
        /// ColumnExpressions will be replaced at a later time by the tier splitter
        /// </summary>
        /// <param name="tableExpression"></param>
        /// <param name="builderContext"></param>
        /// <returns></returns>
        protected virtual Expression GetSelectTableExpression(TableExpression tableExpression, BuilderContext builderContext)
        {
            var bindings = new List<MemberBinding>();
            foreach (var columnExpression in RegisterAllColumns(tableExpression, builderContext))
            {
                var binding = Expression.Bind(columnExpression.MemberInfo, columnExpression);
                bindings.Add(binding);
            }
            var newExpression = Expression.New(tableExpression.Type);
            return Expression.MemberInit(newExpression, bindings);
        }
        /// <summary>
        /// Returns a queried type from a given expression, or null if no type can be found
        /// </summary>
        /// <param name="piece"></param>
        /// <returns></returns>
        public virtual Type GetQueriedType(Expression piece)
        {
            return GetQueriedType(piece.Type);
        }

        /// <summary>
        /// Extracts the type from the potentially generic type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public virtual Type GetQueriedType(Type type)
        {
            if (typeof(IQueryable).IsAssignableFrom(type))
            {
                if (type.IsGenericType)
                    return type.GetGenericArguments()[0];
            }
            return null;
        }

        /// <summary>
        /// Returns the parameter name, if the Expression is a ParameterExpression, null otherwise
        /// </summary>
        /// <param name="piece"></param>
        /// <returns></returns>
        public virtual string GetParameterName(Expression piece)
        {
            if (piece is ParameterExpression)
                return ((ParameterExpression)piece).Name;
            return null;
        }

        /// <summary>
        /// Merges two parameters lists
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public virtual IList<Expression> MergeParameters(IEnumerable<Expression> p1, IEnumerable<Expression> p2)
        {
            var p = new List<Expression>(p1);
            p.AddRange(p2);
            return p;
        }

        /// <summary>
        /// Merges a parameter and a parameter list
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public virtual IList<Expression> MergeParameters(Expression p1, IEnumerable<Expression> p2)
        {
            var p = new List<Expression>();
            p.Add(p1);
            p.AddRange(p2);
            return p;
        }

        /// <summary>
        /// Extracts a subset of a parameters list
        /// </summary>
        /// <param name="pieces"></param>
        /// <param name="first">The index for the first parameter to be kept</param>
        /// <returns></returns>
        public virtual IList<Expression> ExtractParameters(IEnumerable<Expression> pieces, int first)
        {
            return new List<Expression>((from q in pieces select q).Skip(first));
        }
    }
}
