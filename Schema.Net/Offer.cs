using System;

namespace Schema.Net
{
    [Serializable]
    public  class Offer : Intangible
    {
        /*The payment method(s) accepted by seller for this offer.*/
        public  PaymentMethod[] acceptedPaymentMethod;
        /*An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).*/
        public  Offer[] addOn;
        /*The amount of time that is required between accepting the offer and the actual usage of the resource or service.*/
        public  QuantitativeValue[] advanceBookingRequirement;
        /*The overall rating, based on a collection of reviews or ratings, of the item.*/
        public  AggregateRating[] aggregateRating;
        /*The availability of this item&#x2014;for example In stock, Out of stock, Pre-order, etc.*/
        public  ItemAvailability[] availability;
        /*The end of the availability of the product or service included in the offer.*/
        public  string[] availabilityEnds;
        /*The beginning of the availability of the product or service included in the offer.*/
        public  string[] availabilityStarts;
        /*The place(s) from which the offer can be obtained (e.g. store locations).*/
        public  Place[] availableAtOrFrom;
        /*The delivery method(s) available for this offer.*/
        public  DeliveryMethod[] availableDeliveryMethod;
        /*The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.*/
        public  BusinessFunction[] businessFunction;
        /*A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.*/
        public  PhysicalActivityCategory[] category;
        /*The typical delay between the receipt of the order and the goods leaving the warehouse.*/
        public  QuantitativeValue[] deliveryLeadTime;
        /*The type(s) of customers for which the given offer is valid.*/
        public  BusinessEntityType[] eligibleCustomerType;
        /*The duration for which the given offer is valid.*/
        public  QuantitativeValue[] eligibleDuration;
        /*The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.*/
        public  QuantitativeValue[] eligibleQuantity;
        /*The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.*/
        public  GeoShape[] eligibleRegion;
        /*The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.*/
        public  PriceSpecification[] eligibleTransactionVolume;
        /*The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero.*/
        public  string[] gtin13;
        /*The GTIN-14 code of the product, or the product to which the offer refers.*/
        public  string[] gtin14;
        /*The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN.*/
        public  string[] gtin8;
        /*This links to a node or nodes indicating the exact quantity of the products included in the offer.*/
        public  TypeAndQuantityNode[] includesObject;
        /*The current approximate inventory level for the item or items.*/
        public  QuantitativeValue[] inventoryLevel;
        /*A predefined value from OfferItemCondition or a stringual description of the condition of the product or service, or the products or services included in the offer.*/
        public  OfferItemCondition[] itemCondition;
        /*The item being sold.*/
        public  Product[] itemOffered;
        /*The Manufacturer Part string (MPN) of the product, or the product to which the offer refers.*/
        public  string[] mpn;
        /*The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.*/
        public  string[] price;
        /*The currency (in 3-letter ISO 4217 format) of the offer price or a price component, when attached to PriceSpecification and its subtypes.*/
        public  string[] priceCurrency;
        /*One or more detailed price specifications, indicating the unit price and delivery or payment charges.*/
        public  PriceSpecification[] priceSpecification;
        /*The date after which the price is no longer available.*/
        public  string[] priceValidUntil;
        /*A review of the item.*/
        public  Review[] review;
        /*Review of the item (legacy spelling; see singular form, review).*/
        public  Review[] reviews;
        /*The seller.*/
        public  Organization[] seller;
        /*The serial string or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial string of the product included in the offer.*/
        public  string[] serialstring;
        /*The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.*/
        public  string[] sku;
        /*The beginning of the validity of offer, price specification, or opening hours data.*/
        public  string[] validFrom;
        /*The end of the validity of offer, price specification, or opening hours data.*/
        public  string[] validThrough;
        /*The warranty promise(s) included in the offer.*/
        public  WarrantyPromise[] warranty;
    }
}