// ********************************************************************************************************
// <copyright company="NetFluid">
//     Copyright (c) 2013 Matteo Fabbri. All rights reserved.
// </copyright>
// ********************************************************************************************************
// The contents of this file are subject to the GNU AGPL v3.0 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http://www.fsf.org/licensing/licenses/agpl-3.0.html 
// 
// Commercial licenses are also available from http://netfluid.org/, including free evaluation licenses.
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specific language governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this file is Matteo Fabbri.
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date           Changed By      Notes
// 23/10/2013    Matteo Fabbri      Inital coding
// ********************************************************************************************************

using System;
using System.Linq;
using System.Reflection;

namespace Netfluid.Dns.Internals
{
    internal static class Extensions
    {
        public static string ToBase64(this byte[] array)
        {
            return Convert.ToBase64String(array);
        }

        /// <summary>
        ///     Return True if this field has an attribute of type T
        /// </summary>
        public static bool HasAttribute<T>(this FieldInfo type) where T : Attribute
        {
            return type.GetCustomAttributes(false).OfType<T>().Any();
        }

        /// <summary>
        ///     True if the type inherit the given one
        ///     Runtime equivalent of "is" operator
        /// </summary>
        /// <param name="me"></param>
        /// <param name="type">Anchestor to be checked</param>
        public static bool Inherit(this Type me, Type type)
        {
            var t = me;

            while (t != typeof(object) && t != null)
            {
                if (t == type)
                    return true;
                t = t.BaseType;
            }
            return false;
        }

        /// <summary>
        ///     Create an instance of the type
        /// </summary>
        /// <param name="obj">Consructor parameters.None to use default constructor</param>
        public static object CreateIstance(this Type type, params object[] obj)
        {
            return obj == null || obj.Length == 0
                ? Activator.CreateInstance(type)
                : Activator.CreateInstance(type, obj);
        }
    }
}