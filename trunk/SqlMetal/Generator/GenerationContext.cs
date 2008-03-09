﻿#region MIT License
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
using System.Collections.Generic;
using System.Linq;
using DbLinq.Vendor;
using SqlMetal.Generator.Implementation;

namespace SqlMetal.Generator
{
    public class GenerationContext
    {
        public SqlMetalParameters Parameters;
        public IDictionary<string, string> Variables;
        public ISchemaLoader SchemaLoader;

        public List<IClassInterface> KnownClassInterfaces =new List<IClassInterface>();

        public string this[string key]
        {
            get { return Variables[key]; }
            set { Variables[key] = value; }
        }

        public GenerationContext(SqlMetalParameters parameters, ISchemaLoader schemaLoader)
        {
            Parameters = parameters;
            Variables = new Dictionary<string, string>();
            SchemaLoader = schemaLoader;
            KnownClassInterfaces.Add(new IModifiedClassInterface());
        }

        private GenerationContext(GenerationContext original)
        {
            Parameters = original.Parameters;
            Variables = new Dictionary<string, string>(original.Variables);
            SchemaLoader = original.SchemaLoader;
            KnownClassInterfaces = new List<IClassInterface>(original.KnownClassInterfaces);
        }

        public GenerationContext CopyContext()
        {
            return new GenerationContext(this);
        }

        public string Evaluate(string format)
        {
            return Variables.Evaluate(format);
        }

        /// <summary>
        /// Returns all known interface handler that apply to our current interfaces
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IClassInterface> ClassInterfaces()
        {
            foreach (IClassInterface classInterface in KnownClassInterfaces)
            {
                if (Array.Exists(Parameters.Interfaces, interfaceName => classInterface.InterfaceName == interfaceName))
                    yield return classInterface;
            }
        }
    }
}