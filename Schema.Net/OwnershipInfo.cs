using System;

namespace Schema.Net
{
    [Serializable]
    public  class OwnershipInfo : StructuredValue
    {
        /*The organization or person from which the product was acquired.*/
        public  Organization[] acquiredFrom;
        /*The date and time of obtaining the product.*/
        public  string[] ownedFrom;
        /*The date and time of giving up ownership on the product.*/
        public  string[] ownedThrough;
        /*The product that this structured value is referring to.*/
        public  Product[] typeOfGood;
    }
}