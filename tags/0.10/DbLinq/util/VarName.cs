////////////////////////////////////////////////////////////////////
//Initial author: Jiri George Moudry, 2006.
//License: LGPL. (Visit http://www.gnu.org)
//Commercial code may call into this library, if it's in a different module (DLL)
////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

namespace DBLinq.util
{
    /// <summary>
    /// central place to convert C# variable names ('c') into SQL variable names ('c$').
    /// In the future, should handle name conflict.
    /// </summary>
    public static class VarName
    {
        public static string GetSqlName(string csharpName)
        {
            //as of 2006Dec, we were using "$x".
            //That works in MySql, but not Oracle.
            //now we are switching to "x$", which works in both.
            return csharpName+"$";
        }
    }
}