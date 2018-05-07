using System;

namespace Schema.Net
{
    [Serializable]
    public  class ProductModel : Product
    {
        /*A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.*/
        public  ProductModel[] isVariantOf;
        /*A pointer from a previous, often discontinued variant of the product to its newer variant.*/
        public  ProductModel[] predecessorOf;
        /*A pointer from a newer variant of a product  to its previous, often discontinued predecessor.*/
        public  ProductModel[] successorOf;
    }
}