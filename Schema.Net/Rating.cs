using System;

namespace Schema.Net
{
    [Serializable]
    public  class Rating : Intangible
    {
        /*The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.*/
        public  string[] bestRating;
        /*The rating for the content.*/
        public  string[] ratingValue;
        /*The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.*/
        public  string[] worstRating;
    }
}