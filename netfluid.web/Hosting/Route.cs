using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Netfluid
{
    public partial class Route
    {
        string url;
        Regex regex;
        dynamic method;

        protected Route() { }

        public Route(Delegate funcOrAction)
        {
            method = funcOrAction;
            Parameters = funcOrAction.Method.GetParameters();
        }

        public Route(MethodInfo mi, object instance)
        {
            method = new MethodInfoWrapper
            {
                MethodInfo = mi,
                Target = instance
            };

            Parameters = mi.GetParameters();
        }

        public string Name { get; set; }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;

                if (string.IsNullOrEmpty(value)) return;

                var urlRegex = url;
                var find = new Regex(":[^//]+");
                foreach (Match item in find.Matches(url))
                {
                    urlRegex = urlRegex.Replace(item.Value, "(?<" + item.Value.Substring(1) + ">[^//]+?)");
                }
                regex = new Regex("^" + urlRegex + "$");
                GroupNames = regex.GetGroupNames();
            }
        }

        public string HttpMethod { get; set; }

        public int Index { get; set; }

        internal string[] GroupNames { get; private set; }

        internal ParameterInfo[] Parameters { get; private set; }

        internal virtual dynamic Handle(Context cnt)
        {
            if (regex != null)
            {
                var m = regex.Match(cnt.Request.Url.LocalPath);

                if (!m.Success) return false;

                for (int i = 0; i < GroupNames.Length; i++)
                {
                    cnt.Values.Add(GroupNames[i],m.Groups[GroupNames[i]].Value);
                }
            }

            object[] args = null;
            if (Parameters.Length > 0)
            {
                args = new object[Parameters.Length];

                if(cnt.Request.ContentType!=null)
                {
                    if (Parameters.Length == 1 && cnt.Request.ContentType.Contains("json"))
                    {
                        args[0] = JSON.Deserialize(cnt.Reader.ReadToEnd(), Parameters[0].ParameterType);
                        return method.DynamicInvoke(args);
                    }
                    else if (Parameters.Length == 1 && cnt.Request.ContentType.Contains("bson"))
                    {
                        args[0] = BSON.Deserialize(cnt.Request.InputStream, Parameters[0].ParameterType);
                        return method.DynamicInvoke(args);
                    }
                }

                for (int i = 0; i < Parameters.Length; i++)
                {
                    var param = Parameters[i];

                    if (cnt.Values.Contains(param.Name))
                    {
                        args[i] = cnt.Values[param.Name].Parse(param.ParameterType);
                    }
                    else if (param.ParameterType == typeof(Context))
                    {
                        args[i] = cnt;
                    }
                    else if (param.ParameterType.IsValueType)
                    {
                        args[i] = param.ParameterType.DefaultValue();
                    }
                }
            }
            return method.DynamicInvoke(args);
        }

        public static Route New<T0>(Func<T0> f) { return new Route(f); }
        public static Route New<T0, T1>(Func<T0, T1> f) { return new Route(f); }
        public static Route New<T0, T1, T2>(Func<T0, T1, T2> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3>(Func<T0, T1, T2, T3> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4>(Func<T0, T1, T2, T3, T4> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5>(Func<T0, T1, T2, T3, T4, T5> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6>(Func<T0, T1, T2, T3, T4, T5, T6> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7>(Func<T0, T1, T2, T3, T4, T5, T6, T7> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f) { return new Route(f); }

        public static Route New(Action f) { return new Route(f); }
        public static Route New<T0>(Action<T0> f) { return new Route(f); }
        public static Route New<T0, T1>(Action<T0, T1> f) { return new Route(f); }
        public static Route New<T0, T1, T2>(Action<T0, T1, T2> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3>(Action<T0, T1, T2, T3> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4>(Action<T0, T1, T2, T3, T4> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5>(Action<T0, T1, T2, T3, T4, T5> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6>(Action<T0, T1, T2, T3, T4, T5, T6> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7>(Action<T0, T1, T2, T3, T4, T5, T6, T7> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f) { return new Route(f); }
        public static Route New<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f) { return new Route(f); }
    }
}