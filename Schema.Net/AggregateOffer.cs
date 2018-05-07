using System;

namespace Schema.Net
{
    [Serializable]
    public  class AggregateOffer : Offer
    {
        /*The highest price of all offers available.*/
        public  string[] highPrice;
        /*The lowest price of all offers available.*/
        public  string[] lowPrice;
        /*The string of offers for the product.*/
        public  string[] offerCount;
    }
}