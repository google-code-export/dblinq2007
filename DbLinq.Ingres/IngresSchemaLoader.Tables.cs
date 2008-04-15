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

using System.Collections.Generic;
using System.Data;
using DbLinq.Util;
using DbLinq.Vendor;

namespace DbLinq.Ingres
{
    public partial class IngresSchemaLoader
    {
        protected override IDataName ReadDataNameAndSchema(IDataRecord dataRecord)
        {
            var dataName = new DataName { Name = dataRecord.GetAsString(0).TrimEnd(), Schema = dataRecord.GetAsString(1).TrimEnd() };
            return dataName;
        }

        public override IList<IDataName> LoadTablesSchema(IDbConnection connectionString, string databaseName)
        {
            // note: the ReadDataNameAndSchema relies on information order
            const string sql = @"
SELECT table_name, table_owner
FROM iitables 
WHERE table_owner <> '$ingres' 
            AND table_type in ('T', 'V')
            AND table_name NOT LIKE 'iietab_%'";

            return DataCommand.Find<IDataName>(connectionString, sql, ReadDataNameAndSchema);
        }
    }
}