using System;

namespace Netfluid
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class FilterAttribute : RouteAttribute
    {
        public FilterAttribute()
        {
        }

        public FilterAttribute(string url, string method = null, int index = 99999)
        {
            Url = url;
            Method = method;
            Index = index;
        }
    }
}
