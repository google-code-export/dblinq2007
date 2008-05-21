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
using DbLinq.Linq.Data.Sugar.Pieces;

namespace DbLinq.Linq.Data.Sugar
{
    /// <summary>
    /// Represents the first step Expression analysis result
    /// All QueryExpressions are sorted by category
    /// </summary>
    public class PiecesQuery
    {
        // Involved entities
        public IDictionary<Type, IDictionary<string, TablePiece>> MetaTables { get; private set; }
        public IList<TablePiece> Tables { get; private set; }
        public IList<ColumnPiece> Columns { get; private set; }
        // public IDictionary<TablePiece, Piece> Associations { get; private set; } // the key is the associated table
        public IList<ParameterPiece> Parameters { get; private set; }

        // Clauses
        public IList<Piece> Where { get; private set; }
        public Piece Select { get; set; } // the Select clause may be nested

        public PiecesQuery()
        {
            MetaTables = new Dictionary<Type, IDictionary<string, TablePiece>>();
            Tables = new List<TablePiece>();
            Columns = new List<ColumnPiece>();
            // Associations = new Dictionary<TablePiece, Piece>();
            Parameters = new List<ParameterPiece>();
            Where = new List<Piece>();
        }
    }
}
