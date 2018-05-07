using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Netfluid
{
    /// <summary>
    /// GET or POST values recieved from the client
    /// </summary>
    public class QueryValues
    {
        List<string> Values;
        Dictionary<string, QueryValues> Fields;

        public QueryValues()
        {
            Fields = new Dictionary<string, QueryValues>();
            Values = new List<string>();
        }

        public bool Any()
        {
            return Values.Any() | Fields.Any();
        }

        public string this [int index]
        {
            get { return Values[index]; }
            set { Values[index] = value; }
        }

        public QueryValues this[string index]
        {
            get
            {
                if (!Fields.ContainsKey(index)) Fields[index] = new QueryValues();
                return Fields[index];
            }
            set { Fields[index] = value; }
        }

        public void Add(string str)
        {
            Values.Add(str);
        }

        public void Add(string name, string value)
        {
            if(name.Contains('['))
            {
                var parts = name.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                var QV = this;

                foreach (var p in parts)
                {
                    if (!QV.Fields.ContainsKey(p))
                        QV.Fields.Add(p, new QueryValues());

                    QV.Fields[p].Add(value);
                    QV = QV.Fields[p];
                }
                return;
            }

            if (!Fields.ContainsKey(name))
                Fields.Add(name, new QueryValues());

            Fields[name].Add(value);

        }

        public bool Contains(string name)
        {
            return Fields.ContainsKey(name);
        }

        public static implicit operator QueryValues (string q)
        {
            var p = new QueryValues();
            p.Values.Add(q);
            return p;
        }

        public static implicit operator string (QueryValues q)
        {
            return q.Values.Count>0 ? q.Values[0] : null;
        }

        public static implicit operator string[] (QueryValues q)
        {
            return q.Values.ToArray();
        }

        public T Update<T>(T obj)
        {
            var type = obj.GetType();

            foreach (var key in Fields.Keys)
            {
                var field = type.GetField(key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (field != null && !field.HasAttribute<Ignore>())
                {
                    field.SetValue(obj, Fields[key].Parse(field.FieldType));
                }

                var prop = type.GetProperty(key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (prop != null && !prop.HasAttribute<Ignore>())
                {
                    prop.SetValue(obj, Fields[key].Parse(prop.PropertyType), null);
                }
            }
            return obj;
        }

        public T Parse<T>()
        {
            return (T)Parse(typeof(T));
        }

        public object ParseArray(Type elemType)
        {
            if (elemType == typeof(string))
                return Values.ToArray();
            if (elemType == typeof(byte))
                return (Values.Select(byte.Parse)).ToArray();
            if (elemType == typeof(char))
                return (Values.Select(char.Parse)).ToArray();
            if (elemType == typeof(decimal))
                return (Values.Select(decimal.Parse)).ToArray();
            if (elemType == typeof(Int16))
                return (Values.Select(Int16.Parse)).ToArray();
            if (elemType == typeof(UInt16))
                return (Values.Select(UInt16.Parse)).ToArray();
            if (elemType == typeof(Int32))
                return (Values.Select(Int32.Parse)).ToArray();
            if (elemType == typeof(UInt32))
                return (Values.Select(UInt32.Parse)).ToArray();
            if (elemType == typeof(Int64))
                return (Values.Select(Int64.Parse)).ToArray();
            if (elemType == typeof(UInt64))
                return (Values.Select(UInt64.Parse)).ToArray();
            if (elemType == typeof(float))
                return (Values.Select(float.Parse)).ToArray();
            if (elemType == typeof(double))
                return (Values.Select(double.Parse)).ToArray();
            if (elemType == typeof(DateTime))
                return (Values.Select(DateTime.Parse)).ToArray();

            if (elemType == typeof(bool))
            {
                return Values.Select(y =>
                {
                    string t = y.ToLower(CultureInfo.InvariantCulture);
                    return (t == "true" || t == "on" || t == "yes");
                }).ToArray();
            }

            if (elemType.IsEnum)
                return Values.Select(y => Enum.Parse(elemType, y)).ToArray();

            var parsemethod = elemType.GetMethod("Parse", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (parsemethod != null)
            {
                var r = Array.CreateInstance(elemType, Values.Count);

                for (int i = 0; i < r.Length; i++)
                {
                    var o = parsemethod.Invoke(null, new[] { Values[i] });
                    r.SetValue(o, i);
                }

                return r;
            }
            return null;
        }

        public object Parse(Type type)
        {
            if (Values.Count == 0) return type.DefaultValue();

            try
            {
                if (type.IsArray)
                {
                    return ParseArray(type.GetElementType());
                }

                #region VALUES

                if (type == typeof(string))
                    return Values[0];
                if (type == typeof(byte))
                    return byte.Parse(Values[0]);
                if (type == typeof(char))
                    return char.Parse(Values[0]);
                if (type == typeof(decimal))
                    return decimal.Parse(Values[0]);
                if (type == typeof(Int16))
                    return Int16.Parse(Values[0]);
                if (type == typeof(UInt16))
                    return UInt16.Parse(Values[0]);
                if (type == typeof(Int32))
                    return Int32.Parse(Values[0]);
                if (type == typeof(UInt32))
                    return UInt32.Parse(Values[0]);
                if (type == typeof(Int64))
                    return Int64.Parse(Values[0]);
                if (type == typeof(UInt64))
                    return UInt64.Parse(Values[0]);
                if (type == typeof(float))
                    return float.Parse(Values[0]);
                if (type == typeof(double))
                    return double.Parse(Values[0]);
                if (type == typeof(DateTime))
                    return DateTime.Parse(Values[0]);

                if (type == typeof(bool))
                {
                    string t = Values[0].ToLower(CultureInfo.InvariantCulture);
                    return t == "true" || t == "on" || t == "yes";
                }

                if (type.IsEnum)
                    return Enum.Parse(type, Values[0], true);

                var method = type.GetMethod("Parse", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
                if (method != null && Values.Count >0)
                    return method.Invoke(null, new[] { Values[0] });
                #endregion

                #region OBJECTS
                if (type.IsClass)
                {
                    var instance = type.CreateIstance();

                    foreach (var key in Fields.Keys)
                    {
                        var field = type.GetField(key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                        if (field != null)
                        {
                            try
                            {
                                field.SetValue(instance, Fields[key].Parse(field.FieldType));
                            }
                            catch (Exception)
                            {
                            }
                        }

                        var prop = type.GetProperty(key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                        if (prop != null && prop.GetSetMethod() != null)
                        {
                            try
                            {
                                prop.SetValue(instance, Fields[key].Parse(prop.PropertyType), null);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }

                    return instance;
                }
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return type.IsValueType ? Activator.CreateInstance(type) : null;
        }
    }
}