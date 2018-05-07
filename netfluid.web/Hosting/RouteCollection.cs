using System;
using System.Linq;
using System.Collections.Generic;

namespace Netfluid
{
    public class RouteCollection: List<Route>
    {
        public Route this[string httpMethod,string url]
        {
            set
            {
                value.HttpMethod = httpMethod;
                value.Url = url;
                base.Add(value);
            }
        }
        public Route this[string url]
        {
            set
            {
                value.HttpMethod = null;
                value.Url = url;
                base.Add(value);
            }
        }
    }
}
