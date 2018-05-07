using System;

namespace Schema.Net
{
    [Serializable]
    public  class GeoShape : StructuredValue
    {
        /*A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more spacedelimited points where the first and final points are identical.*/
        public  string[] box;
        /*A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.*/
        public  string[] circle;
        /*The elevation of a location.*/
        public  string[] elevation;
        /*A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.*/
        public  string[] line;
        /*A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more spacedelimited points where the first and final points are identical.*/
        public  string[] polygon;
    }
}