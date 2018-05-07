using System;

namespace Schema.Net
{
    [Serializable]
    public  class Product : Thing
    {
        /*The overall rating, based on a collection of reviews or ratings, of the item.*/
        public  AggregateRating[] aggregateRating;
        /*The intended audience of the item, i.e. the group for whom the item was created.*/
        public  Audience[] audience;
        /*The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.*/
        public  Brand[] brand;
        /*The color of the product.*/
        public  string[] color;
        /*The depth of the product.*/
        public  string[] depth;
        /*The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero.*/
        public  string[] gtin13;
        /*The GTIN-14 code of the product, or the product to which the offer refers.*/
        public  string[] gtin14;
        /*The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN.*/
        public  string[] gtin8;
        /*The height of the item.*/
        public  string[] height;
        /*A pointer to another product (or multiple products) for which this product is an accessory or spare part.*/
        public  Product[] isAccessoryOrSparePartFor;
        /*A pointer to another product (or multiple products) for which this product is a consumable.*/
        public  Product[] isConsumableFor;
        /*A pointer to another, somehow related product (or multiple products).*/
        public  Product[] isRelatedTo;
        /*A pointer to another, functionally similar product (or multiple products).*/
        public  Product[] isSimilarTo;
        /*A predefined value from OfferItemCondition or a stringual description of the condition of the product or service, or the products or services included in the offer.*/
        public  OfferItemCondition[] itemCondition;
        /*string of an image for the logo of the item.*/
        public  ImageObject[] logo;
        /*The manufacturer of the product.*/
        public  Organization[] manufacturer;
        /*The model of the product. Use with the string of a ProductModel or a stringual representation of the model identifier. The string of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.*/
        public  ProductModel[] model;
        /*The Manufacturer Part string (MPN) of the product, or the product to which the offer refers.*/
        public  string[] mpn;
        /*An offer to sell this item&#x2014;for example, an offer to sell a product, the DVD of a movie, or tickets to an event.*/
        public  Offer[] offers;
        /*The product identifier, such as ISBN. For example: &lt;meta itemprop='productID' content='isbn:123-456-789'/&gt;.*/
        public  string[] productID;
        /*The release date of a product or product model. This can be used to distinguish the exact variant of a product.*/
        public  string[] releaseDate;
        /*A review of the item.*/
        public  Review[] review;
        /*Review of the item (legacy spelling; see singular form, review).*/
        public  Review[] reviews;
        /*The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.*/
        public  string[] sku;
        /*The weight of the product.*/
        public  QuantitativeValue[] weight;
        /*The width of the item.*/
        public  string[] width;
    }
}