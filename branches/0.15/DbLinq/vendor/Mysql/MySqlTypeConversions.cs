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

using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DBLinq.vendor
{
    /// <summary>
    /// helper class which help to convert MySql's types to MySqlClient .NET types,
    /// eg. 'tinyint' to MySqlDbType.Int16.
    /// </summary>
    public static class MySqlTypeConversions
    {
        static Dictionary<string,MySqlDbType> s_typeMap = new Dictionary<string,MySqlDbType>();

        static MySqlTypeConversions()
        {
            foreach(MySqlDbType dbType in Enum.GetValues(typeof(MySqlDbType)) )
            {
                s_typeMap[dbType.ToString().ToLower()] = dbType;
            }
        }

        /// <summary>
        /// given name of MySqlType, return it's MySqlDbType enum.
        /// </summary>
        public static MySqlDbType ParseType(string typeStr)
        {
            string typeStrL = typeStr.ToLower();
            if (!s_typeMap.ContainsKey(typeStrL))
            {
                int indxBraket = typeStrL.IndexOf('(');
                if (indxBraket > -1)
                {
                    typeStrL = typeStrL.Substring(0, indxBraket);
                }

                switch (typeStrL)
                {
                    case "char":
                    case "text":
                    case "longtext":
                        return MySqlDbType.String;
                    case "varchar":
                        return MySqlDbType.VarChar;
                    case "bit":
                        return MySqlDbType.Bit;
                    case "int":
                        return MySqlDbType.Int32;

                    case "int unsigned":
                        //Laurent Morisseau writes:
                        //If you map to MySqlDbType.UInt32, you get the following MySql error: 
                        //"Only byte arrays and strings can be serialized by MySqlBinary"
                        return MySqlDbType.Int32;

                    case "mediumint":
                    case "mediumint unsigned":
                        return MySqlDbType.Int24; //go figure - MEDIUMINT is 3 bytes 
                    case "smallint":
                        return MySqlDbType.Int16;
                    case "tinyint":
                        return MySqlDbType.Byte;
                }
                string msg = "TODO L24: add parsing of type " + typeStr;
                Console.WriteLine(msg);
                throw new ApplicationException(msg);
            }
            return s_typeMap[typeStrL];
        }
    }
}