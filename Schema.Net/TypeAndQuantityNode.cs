using System;

namespace Schema.Net
{
    [Serializable]
    public  class TypeAndQuantityNode : StructuredValue
    {
        /*The quantity of the goods included in the offer.*/
        public  string[] amountOfThisGood;
        /*The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.*/
        public  BusinessFunction[] businessFunction;
        /*The product that this structured value is referring to.*/
        public  Product[] typeOfGood;
        /*The unit of measurement given using the UN/CEFACT Common Code (3 characters).*/
        public  string[] unitCode;
    }
}