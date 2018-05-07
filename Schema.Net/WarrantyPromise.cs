using System;

namespace Schema.Net
{
    [Serializable]
    public  class WarrantyPromise : StructuredValue
    {
        /*The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.*/
        public  QuantitativeValue[] durationOfWarranty;
        /*The scope of the warranty promise.*/
        public  WarrantyScope[] warrantyScope;
    }
}