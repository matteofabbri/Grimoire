using System;

namespace Netfluid
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TriggerAttribute : RouteAttribute
    {
        public TriggerAttribute()
        {
        }

        public TriggerAttribute(string url, string method = null, int index = 99999)
        {
            this.Url = url;
            Method = method;
            Index = index;
        }
    }
}
