using System;

namespace Schema.Net
{
    [Serializable]
    public  class IndividualProduct : Product
    {
        /*The serial string or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial string of the product included in the offer.*/
        public  string[] serialstring;
    }
}