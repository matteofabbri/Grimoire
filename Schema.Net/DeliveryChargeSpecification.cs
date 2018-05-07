using System;

namespace Schema.Net
{
    [Serializable]
    public  class DeliveryChargeSpecification : PriceSpecification
    {
        /*The delivery method(s) to which the delivery charge or payment charge specification applies.*/
        public  DeliveryMethod[] appliesToDeliveryMethod;
        /*The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.*/
        public  GeoShape[] eligibleRegion;
    }
}