using System;

namespace Schema.Net
{
    [Serializable]
    public  class WebApplication : SoftwareApplication
    {
        /*Specifies browser requirements in human-readable string. For example,"requires HTML5 support".*/
        public  string[] browserRequirements;
    }
}