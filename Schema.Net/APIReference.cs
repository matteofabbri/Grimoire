using System;

namespace Schema.Net
{
    [Serializable]
    public  class APIReference : TechArticle
    {
        /*Library file name e.g., mscorlib.dll, system.web.dll*/
        public  string[] assembly;
        /*Associated product/technology version. e.g., .NET Framework 4.5*/
        public  string[] assemblyVersion;
        /*Indicates whether API is managed or unmanaged.*/
        public  string[] programmingModel;
        /*Type of app development: phone, Metro style, desktop, XBox, etc.*/
        public  string[] targetPlatform;
    }
}