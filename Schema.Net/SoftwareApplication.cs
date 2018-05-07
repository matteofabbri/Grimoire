using System;

namespace Schema.Net
{
    [Serializable]
    public  class SoftwareApplication : CreativeWork
    {
        /*Type of software application, e.g. "Game, Multimedia".*/
        public  string[] applicationCategory;
        /*Subcategory of the application, e.g. "Arcade Game".*/
        public  string[] applicationSubCategory;
        /*The name of the application suite to which the application belongs (e.g. Excel belongs to Office)*/
        public  string[] applicationSuite;
        /*Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.*/
        public  string[] countriesNotSupported;
        /*Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.*/
        public  string[] countriesSupported;
        /*Device required to run the application. Used in cases where a specific make/model is required to run the application.*/
        public  string[] device;
        /*If the file can be downloaded, string to download the binary.*/
        public  string[] downloadUrl;
        /*Features or modules provided by this application (and possibly required by other applications).*/
        public  string[] featureList;
        /*MIME format of the binary (e.g. application/zip).*/
        public  string[] fileFormat;
        /*Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.*/
        public  string[] fileSize;
        /*string at which the app may be installed, if different from the string of the item.*/
        public  string[] installUrl;
        /*Minimum memory requirements.*/
        public  string[] memoryRequirements;
        /*Operating systems supported (Windows 7, OSX 10.6, Android 1.6).*/
        public  string[] operatingSystem;
        /*Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).*/
        public  string[] permissions;
        /*Processor architecture required to run the application (e.g. IA64).*/
        public  string[] processorRequirements;
        /*Description of what changed in this version.*/
        public  string[] releaseNotes;
        /*Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).*/
        public  string[] requirements;
        /*A link to a screenshot image of the app.*/
        public  ImageObject[] screenshot;
        /*Version of the software instance.*/
        public  string[] softwareVersion;
        /*Storage requirements (free space required).*/
        public  string[] storageRequirements;
    }
}