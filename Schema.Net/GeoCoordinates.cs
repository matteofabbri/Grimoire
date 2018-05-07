using System;

namespace Schema.Net
{
    [Serializable]
    public  class GeoCoordinates : StructuredValue
    {
        /*The elevation of a location.*/
        public  string[] elevation;
        /*The latitude of a location. For example 37.42242.*/
        public  string[] latitude;
        /*The longitude of a location. For example -122.08585.*/
        public  string[] longitude;
    }
}