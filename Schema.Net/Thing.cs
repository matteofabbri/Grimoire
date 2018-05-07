using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace Schema.Net
{
    public class Thing
    {
        public string type;
        public  string[] additionalType;
        public  string[] description;
        public  string[] image;
        public  string[] name;
        public string[] url;

        public Thing()
        {
            type = GetType().Name;
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        ///     Return all inherited types
        /// </summary>
        static Type[] Ancestor(Type me)
        {
            Type t = me;
            var result = new List<Type>();
            while (t != typeof(object) && t != null)
            {
                if (t != typeof(object))
                {
                    result.Add(t);
                }
                t = t.BaseType;
            }
            return result.ToArray();
        }


        public override string ToString()
        {
            Type type = GetType();
            var sb = new StringBuilder();

            sb.AppendLine("<table class=\"" + string.Join(" ", Ancestor(type).Select(x => x.Name)) + "\">");
            foreach (FieldInfo fi in type.GetFields())
            {
                object value = fi.GetValue(this);

                if (value != null && fi.Name != "MissingData")
                {
                    sb.AppendLine("<tr>");
                    sb.AppendLine("<td>" + fi.Name + "</td>");
                    sb.AppendLine("<td>");
                    var enu = value as IEnumerable;
                    foreach (object v in enu)
                    {
                        if (v != null)
                        {
                            sb.AppendLine(v.ToString());
                        }
                    }
                    sb.AppendLine("</td>");
                    sb.AppendLine("</tr>");
                }
            }
            sb.AppendLine("</table>");
            return sb.ToString();
        }
    }
}