using System;

namespace Schema.Net
{
    [Serializable]
    public  class UnitPriceSpecification : PriceSpecification
    {
        /*This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.*/
        public  string[] billingIncrement;
        /*A short string or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.*/
        public  string[] priceType;
        /*The unit of measurement given using the UN/CEFACT Common Code (3 characters).*/
        public  string[] unitCode;
    }
}