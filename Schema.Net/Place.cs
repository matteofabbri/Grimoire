using System;

namespace Schema.Net
{
    [Serializable]
    public  class Place : Thing
    {
        /*Physical address of the item.*/
        public  PostalAddress[] address;
        /*The overall rating, based on a collection of reviews or ratings, of the item.*/
        public  AggregateRating[] aggregateRating;
        /*The basic containment relation between places.*/
        public  Place[] containedIn;
        /*Upcoming or past event associated with this place or organization.*/
        public  Event[] @event;
        /*Upcoming or past events associated with this place or organization (legacy spelling; see singular form, event).*/
        public  Event[] events;
        /*The fax string.*/
        public  string[] faxstring;
        /*The geo coordinates of the place.*/
        public  GeoCoordinates[] geo;
        /*The Global Location string (GLN, sometimes also referred to as International Location string or ILN) of the respective organization, person, or place. The GLN is a 13-digit string used to identify parties and physical locations.*/
        public  string[] globalLocationstring;
        /*A count of a specific user interactions with this item&#x2014;for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.*/
        public  string[] interactionCount;
        /*The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.*/
        public  string[] isicV4;
        /*string of an image for the logo of the item.*/
        public  ImageObject[] logo;
        /*A string to a map of the place.*/
        public  string[] map;
        /*A string to a map of the place (legacy spelling; see singular form, map).*/
        public  string[] maps;
        /*The opening hours of a certain place.*/
        public  OpeningHoursSpecification[] openingHoursSpecification;
        /*A photograph of this place.*/
        public  ImageObject[] photo;
        /*Photographs of this place (legacy spelling; see singular form, photo).*/
        public  ImageObject[] photos;
        /*A review of the item.*/
        public  Review[] review;
        /*Review of the item (legacy spelling; see singular form, review).*/
        public  Review[] reviews;
        /*The telephone string.*/
        public  string[] telephone;
    }
}