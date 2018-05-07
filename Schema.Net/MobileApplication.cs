using System;

namespace Schema.Net
{
    [Serializable]
    public  class MobileApplication : SoftwareApplication
    {
        /*Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).*/
        public  string[] carrierRequirements;
    }
}