using System;
using System.Reflection;

namespace Netfluid
{
    class MethodInfoWrapper
    {
        internal object Target;

        internal MethodInfo MethodInfo;

        public object DynamicInvoke(object[] parameters)
        {
            return MethodInfo.Invoke(Target, parameters);
        }
    }
}
