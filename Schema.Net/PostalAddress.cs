using System;

namespace Schema.Net
{
    [Serializable]
    public  class PostalAddress : ContactPoint
    {
        /*The country. For example, USA. You can also provide the two-letter ISO 3166-1 alpha-2 country code.*/
        public  Country[] addressCountry;
        /*The locality. For example, Mountain View.*/
        public  string[] addressLocality;
        /*The region. For example, CA.*/
        public  string[] addressRegion;
        /*The postal code. For example, 94043.*/
        /*The post offce box string for PO box addresses.*/
        public  string[] postOfficeBoxstring;
        public  string[] postalCode;
        /*The street address. For example, 1600 Amphitheatre Pkwy.*/
        public  string[] streetAddress;
    }
}