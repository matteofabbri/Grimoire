using System;

namespace Schema.Net
{
    [Serializable]
    public  class ContactPoint : StructuredValue
    {
        /*A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.*/
        public  string[] contactType;
        /*Email address.*/
        public  string[] email;
        /*The fax string.*/
        public  string[] faxstring;
        /*The telephone string.*/
        public  string[] telephone;
    }
}