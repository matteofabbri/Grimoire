using System;

namespace Schema.Net
{
    [Serializable]
    public  class Review : CreativeWork
    {
        /*The item that is being reviewed/rated.*/
        public  Thing[] itemReviewed;
        /*The actual body of the review*/
        public  string[] reviewBody;
        /*The rating given in this review. Note that reviews can themselves be rated. The reviewRating applies to rating given by the review. The aggregateRating property applies to the review itself, as a creative work.*/
        public  Rating[] reviewRating;
    }
}