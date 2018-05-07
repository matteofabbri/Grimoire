using System;

namespace Schema.Net
{
    [Serializable]
    public  class SomeProducts : Product
    {
        /*The current approximate inventory level for the item or items.*/
        public  QuantitativeValue[] inventoryLevel;
    }
}