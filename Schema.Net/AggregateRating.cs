using System;

namespace Schema.Net
{
    [Serializable]
    public  class AggregateRating : Rating
    {
        /*The item that is being reviewed/rated.*/
        public  Thing[] itemReviewed;
        /*The count of total string of ratings.*/
        public  string[] ratingCount;
        /*The count of total string of reviews.*/
        public  string[] reviewCount;
    }
}