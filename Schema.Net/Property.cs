using System;

namespace Schema.Net
{
    [Serializable]
    public  class Property : Thing
    {
        /*Relates a property to a class that is (one of) the type(s) the property is expected to be used on.*/
        public  Class[] domainIncludes;
        /*Relates a property to a class that constitutes (one of) the expected type(s) for values of the property.*/
        public  Class[] rangeIncludes;
    }
}