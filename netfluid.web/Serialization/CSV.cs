
//Based on Simple and fast CSV library in C# by By Pascal Ganaye
//http://www.codeproject.com/Articles/685310/Simple-and-fast-CSV-library-in-Csharp

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Netfluid.Serialization;

namespace Netfluid
{
    /// <summary>
    /// CSV Serializer and Deserializer
    /// </summary>
    public static class CSV
    {
        /// <summary>
        /// Deserialize a CSV into a collection of objects
        /// </summary>
        /// <typeparam name="T">objects target type (it must implement default public constructor)</typeparam>
        /// <param name="reader">CSV reader</param>
        /// <param name="fieldSeparator">CSV field separator.Default value: ';'</param>
        /// <param name="textQualifier">CSV string delimiter.Default value: '"'</param>
        /// <returns>collections of T objects</returns>
        public static IEnumerable<T> Deserialize<T>(StreamReader reader, char fieldSeparator = ';', char textQualifier = '"') where T : new()
        {
            return new CsvReader<T>(reader, fieldSeparator, textQualifier);
        }

        /// <summary>
        /// Deserialize a CSV into a collection of objects
        /// </summary>
        /// <typeparam name="T">objects target type (it must implement default public constructor)</typeparam>
        /// <param name="stream">CSV source stream (ex: new FileStream("my file.csv"))</param>
        /// <param name="fieldSeparator">CSV field separator.Default value: ';'</param>
        /// <param name="textQualifier">CSV string delimiter.Default value: '"'</param>
        /// <returns>collections of T objects</returns>
        public static IEnumerable<T> Deserialize<T>(Stream stream, char fieldSeparator = ';', char textQualifier = '"') where T : new()
        { 
            return new CsvReader<T>(new StreamReader(stream),fieldSeparator,textQualifier);
        }

        /// <summary>
        /// Transform a collection of objects into a CSV
        /// </summary>
        /// <typeparam name="T">objects target type (it must implement default public constructor)</typeparam>
        /// <param name="collection">collection to save</param>
        /// <param name="writer">target streamwiter</param>
        /// <param name="fieldSeparator">CSV field separator.Default value: ';'</param>
        /// <param name="textQualifier">CSV string delimiter.Default value: '"'</param>
        /// <returns>collections of T objects</returns>
        public static void Serialize<T>(IEnumerable<T> collection, StreamWriter writer, char fieldSeparator = ';', char textQualifier = '"')
        {
            var type = (typeof(T));

            var columns = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(pi =>
            {
                if (pi.GetIndexParameters().Length == 0 && !pi.HasAttribute<Ignore>())
                    return true;

                return false;
             }).Select(pi => pi.Name).ToArray();

            if (columns.Length == 0)
            {
                columns = type.GetFields(BindingFlags.Public | BindingFlags.Instance).Select(fi => fi.Name).ToArray();
            }


            var fieldSeparatorAsString = fieldSeparator.ToString(CultureInfo.InvariantCulture);
            var invalidCharsInFields = new[] { '\r', '\n', textQualifier, fieldSeparator };

            var csvLine = new StringBuilder();
            for (int i = 0; i < columns.Length; i++)
            {
                if (i > 0)
                    csvLine.Append(fieldSeparator);
                csvLine.Append(ToCsvString<T>(columns[i], textQualifier, invalidCharsInFields));
            }
            writer.WriteLine(csvLine.ToString());

            var getters = columns.Select(columnName =>
            {
                var propertyName = (columnName.IndexOf(' ') < 0 ? columnName : columnName.Replace(" ", ""));
                return FindGetter<T>(columnName, false) ?? FindGetter<T>(columnName, true);
            }).ToArray();

            foreach (var item in collection)
            {
                var csvStrings = new string[getters.Length];

                for (int i = 0; i < getters.Length; i++)
                {
                    var getter = getters[i];
                    object fieldValue = getter == null ? null : getter(item);
                    csvStrings[i] = ToCsvString<T>(fieldValue, textQualifier, invalidCharsInFields);
                }
                writer.WriteLine(string.Join(fieldSeparatorAsString, csvStrings));
            }
            writer.Flush();
        }

        static Func<T, object> FindGetter<T>(string c, bool staticMember)
        {
            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.IgnoreCase | (staticMember ? BindingFlags.Static : BindingFlags.Instance);
            Func<T, object> func = null;
            var pi = typeof(T).GetProperty(c, flags);
            var fi = typeof(T).GetField(c, flags);

            Expression expr = null;
            var parameter = Expression.Parameter(typeof(T), "r");
            Type type = null;

            if (pi != null)
            {
                type = pi.PropertyType;
                expr = Expression.Property(parameter, pi.Name);
            }
            else if (fi != null)
            {
                type = fi.FieldType;
                expr = Expression.Field(parameter, fi.Name);
            }
            if (expr != null)
            {
                Expression<Func<T, object>> lambda;
                if (type.IsValueType)
                {
                    lambda = Expression.Lambda<Func<T, object>>(Expression.TypeAs(expr, typeof(object)), parameter);
                }
                else
                {
                    lambda = Expression.Lambda<Func<T, object>>(expr, parameter);
                }
                func = lambda.Compile();
            }
            return func;
        }

        static string ToCsvString<T>(object o, char textQualifier, char[] invalidCharsInFields)
        {
            if (o == null) return string.Empty;
            var valueString = o as string ?? Convert.ToString(o, CultureInfo.CurrentUICulture);
            if (valueString.IndexOfAny(invalidCharsInFields) >= 0)
            {
                var csvLine = new StringBuilder();
                csvLine.Append(textQualifier);
                foreach (char c in valueString)
                {
                    if (c == textQualifier)
                        csvLine.Append(c); // double the double quotes
                    csvLine.Append(c);
                }
                csvLine.Append(textQualifier);
                return csvLine.ToString();
            }
            else
                return valueString;
        }
    }
}
