﻿#region MIT license
////////////////////////////////////////////////////////////////////
// MIT license:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//
// Authors:
//        Jiri George Moudry
////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.Data.Linq.Mapping;

namespace DbLinq.Linq.Mapping
{
    /// <summary>
    /// This is an 'extension' of Microsoft's [Linq.Mapping.Function] attribute.
    /// We need one extra field to indicate type of code - ProcOrFunction.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    [Obsolete("Please use FunctionAttribute instead")]
    public class FunctionExAttribute : Attribute
    {
        public string Name { get; set; }

        /// <summary>
        /// needed because MySql semantics of invoking a func are different from a proc.
        /// </summary>
        public string ProcedureOrFunction { get; set; }

        internal FunctionAttribute FunctionAttribute
        {
            get
            {
                return new FunctionAttribute { Name = Name, IsComposable = ProcedureOrFunction != "PROCEDURE" };
            }
        }
    }
}