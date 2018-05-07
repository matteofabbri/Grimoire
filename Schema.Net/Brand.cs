using System;

namespace Schema.Net
{
    [Serializable]
    public  class Brand : Intangible
    {
        /*string of an image for the logo of the item.*/
        public  ImageObject[] logo;
    }
}