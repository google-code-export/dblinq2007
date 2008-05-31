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
using System.Linq.Expressions;
using DbLinq.Linq.Data.Sugar.Expressions;

namespace DbLinq.Linq.Data.Sugar
{
    public class BuilderContext
    {
        // Global context
        public QueryContext QueryContext { get; private set; }

        // Current expression being built
        public ExpressionQuery ExpressionQuery { get; private set; }

        // Build context: values here are related to current context, and can change with it
        private int currentScopeIndex;
        public ScopeExpression CurrentScope
        {
            get { return ScopeExpressions[currentScopeIndex]; }
            set { ScopeExpressions[currentScopeIndex] = value; }
        }
        public IList<ScopeExpression> ScopeExpressions { get; private set; }
        public IDictionary<Type, MetaTableExpression> MetaTables { get; private set; }
        public IDictionary<string, Expression> Parameters { get; private set; }

        /// <summary>
        /// Helper to enumerate all registered tables
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TableExpression> EnumerateAllTables()
        {
            foreach (var scopePiece in ScopeExpressions)
            {
                foreach (var table in scopePiece.Tables)
                    yield return table;
            }
        }

        /// <summary>
        /// Helper to enumerate all registered columns
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TableExpression> EnumerateScopeTables()
        {
            for (ScopeExpression currentScope = CurrentScope; currentScope != null; currentScope = currentScope.Parent)
            {
                foreach (var table in currentScope.Tables)
                    yield return table;
            }
        }

        /// <summary>
        /// Helper to enumerate all registered columns
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ColumnExpression> EnumerateScopeColumns()
        {
            for (ScopeExpression currentScope = CurrentScope; currentScope != null; currentScope = currentScope.Parent)
            {
                foreach (var column in currentScope.Columns)
                    yield return column;
            }
        }

        public BuilderContext(QueryContext queryContext)
        {
            ScopeExpressions = new List<ScopeExpression>();
            currentScopeIndex = ScopeExpressions.Count;
            ScopeExpressions.Add(new ScopeExpression());
            QueryContext = queryContext;
            ExpressionQuery = new ExpressionQuery();
            MetaTables = new Dictionary<Type, MetaTableExpression>();
            Parameters = new Dictionary<string, Expression>();
        }

        private BuilderContext()
        { }

        /// <summary>
        /// Creates a new BuilderContext where parameters have a local scope
        /// </summary>
        /// <returns></returns>
        public BuilderContext NewQuote()
        {
            var builderContext = new BuilderContext();

            // scope independent parts
            builderContext.QueryContext = QueryContext;
            builderContext.ExpressionQuery = ExpressionQuery;
            builderContext.MetaTables = MetaTables;
            builderContext.currentScopeIndex = currentScopeIndex;
            builderContext.ScopeExpressions = ScopeExpressions;

            // scope dependent parts
            builderContext.Parameters = new Dictionary<string, Expression>(Parameters);

            return builderContext;
        }

        /// <summary>
        /// Creates a new BuilderContext with a new query scope
        /// </summary>
        /// <returns></returns>
        public BuilderContext NewScope()
        {
            var builderContext = new BuilderContext();

            // we basically copy everything
            builderContext.QueryContext = QueryContext;
            builderContext.ExpressionQuery = ExpressionQuery;
            builderContext.MetaTables = MetaTables;
            builderContext.Parameters = Parameters;
            builderContext.ScopeExpressions = ScopeExpressions;

            // except CurrentScope, of course
            builderContext.currentScopeIndex = ScopeExpressions.Count;
            ScopeExpressions.Add(new ScopeExpression(CurrentScope));

            return builderContext;
        }
    }
}