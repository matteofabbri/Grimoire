using System;

namespace Schema.Net
{
    [Serializable]
    public  class ParentAudience : PeopleAudience
    {
        /*Maximal age of the child*/
        public  string[] childMaxAge;
        /*Minimal age of the child*/
        public  string[] childMinAge;
    }
}