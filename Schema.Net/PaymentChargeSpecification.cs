using System;

namespace Schema.Net
{
    [Serializable]
    public  class PaymentChargeSpecification : PriceSpecification
    {
        /*The delivery method(s) to which the delivery charge or payment charge specification applies.*/
        public  DeliveryMethod[] appliesToDeliveryMethod;
        /*The payment method(s) to which the payment charge specification applies.*/
        public  PaymentMethod[] appliesToPaymentMethod;
    }
}