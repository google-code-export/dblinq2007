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
using DbLinq.Linq.Data.Sugar.Expressions;

namespace DbLinq.Linq.Data.Sugar
{
    /// <summary>
    /// Represents the first step Expression analysis result
    /// All QueryExpressions are sorted by category
    /// </summary>
    public class ExpressionQuery : AbstractQuery
    {
        // Involved entities
        public IDictionary<Type, IDictionary<string, QueryTableExpression>> MetaTables { get; private set; }
        public IList<QueryTableExpression> Tables { get; private set; }
        public IList<QueryColumnExpression> Columns { get; private set; }
        public IDictionary<QueryTableExpression, QueryExpression> Associations { get; private set; } // the key is the associated table

        // Clauses
        public IList<QueryExpression> Where { get; private set; }
        public QueryExpression Select { get; set; } // the Select clause may be nested

        public ExpressionQuery()
        {
            MetaTables = new Dictionary<Type, IDictionary<string, QueryTableExpression>>();
            Tables = new List<QueryTableExpression>();
            Columns = new List<QueryColumnExpression>();
            Associations = new Dictionary<QueryTableExpression, QueryExpression>();
            Where = new List<QueryExpression>();
        }
    }
}