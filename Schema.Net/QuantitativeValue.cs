using System;

namespace Schema.Net
{
    [Serializable]
    public  class QuantitativeValue : StructuredValue
    {
        /*The upper of the product characteristic.*/
        public  string[] maxValue;
        /*The lower value of the product characteristic.*/
        public  string[] minValue;
        /*The unit of measurement given using the UN/CEFACT Common Code (3 characters).*/
        public  string[] unitCode;
        /*The value of the product characteristic.*/
        public  string[] value;
        /*A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.*/
        public  Enumeration[] valueReference;
    }
}