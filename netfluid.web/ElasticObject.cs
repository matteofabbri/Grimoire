using System;
using System.Collections.Generic;
using System.Dynamic;


namespace Netfluid
{
    public class ElasticObject : DynamicObject
    {
        private Dictionary<string, object> _properties = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (!_properties.TryGetValue(binder.Name, out result))
                result = new ElasticObject();

            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _properties[binder.Name] = value;
            return true;
        }
    }
}
