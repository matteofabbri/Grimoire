using System;

namespace Schema.Net
{
    [Serializable]
    public  class PriceSpecification : StructuredValue
    {
        /*The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.*/
        public  QuantitativeValue[] eligibleQuantity;
        /*The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.*/
        public  PriceSpecification[] eligibleTransactionVolume;
        /*The highest price if the price is a range.*/
        public  string[] maxPrice;
        /*The lowest price if the price is a range.*/
        public  string[] minPrice;
        /*The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.*/
        public  string[] price;
        /*The currency (in 3-letter ISO 4217 format) of the offer price or a price component, when attached to PriceSpecification and its subtypes.*/
        public  string[] priceCurrency;
        /*The beginning of the validity of offer, price specification, or opening hours data.*/
        public  string[] validFrom;
        /*The end of the validity of offer, price specification, or opening hours data.*/
        public  string[] validThrough;
        /*Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.*/
        public  string[] valueAddedTaxIncluded;
    }
}