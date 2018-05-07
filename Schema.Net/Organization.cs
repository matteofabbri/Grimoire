using System;

namespace Schema.Net
{
    [Serializable]
    public  class Organization : Thing
    {
        /*Physical address of the item.*/
        public  PostalAddress[] address;
        /*The overall rating, based on a collection of reviews or ratings, of the item.*/
        public  AggregateRating[] aggregateRating;
        /*The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.*/
        public  Brand[] brand;
        /*A contact point for a person or organization.*/
        public  ContactPoint[] contactPoint;
        /*A contact point for a person or organization (legacy spelling; see singular form, contactPoint).*/
        public  ContactPoint[] contactPoints;
        /*The Dun & Bradstreet DUNS string for identifying an organization or business person.*/
        public  string[] duns;
        /*Email address.*/
        public  string[] email;
        /*Someone working for this organization.*/
        public  Person[] employee;
        /*People working for this organization. (legacy spelling; see singular form, employee)*/
        public  Person[] employees;
        /*Upcoming or past event associated with this place or organization.*/
        public  Event[] @event;
        /*Upcoming or past events associated with this place or organization (legacy spelling; see singular form, event).*/
        public  Event[] events;
        /*The fax string.*/
        public  string[] faxstring;
        /*A person who founded this organization.*/
        public  Person[] founder;
        /*A person who founded this organization (legacy spelling; see singular form, founder).*/
        public  Person[] founders;
        /*The date that this organization was founded.*/
        public  string[] foundingDate;
        /*The Global Location string (GLN, sometimes also referred to as International Location string or ILN) of the respective organization, person, or place. The GLN is a 13-digit string used to identify parties and physical locations.*/
        public  string[] globalLocationstring;
        /*Points-of-Sales operated by the organization or person.*/
        public  Place[] hasPOS;
        /*A count of a specific user interactions with this item&#x2014;for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.*/
        public  string[] interactionCount;
        /*The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.*/
        public  string[] isicV4;
        /*The official name of the organization, e.g. the registered company name.*/
        public  string[] legalName;
        /*The location of the event or organization.*/
        public  Place[] location;
        /*string of an image for the logo of the item.*/
        public  ImageObject[] logo;
        /*A pointer to products or services offered by the organization or person.*/
        public  Offer[] makesOffer;
        /*A member of this organization.*/
        public  Organization[] member;
        /*A member of this organization (legacy spelling; see singular form, member).*/
        public  Organization[] members;
        /*The North American Industry Classification System (NAICS) code for a particular organization or business person.*/
        public  string[] naics;
        /*Products owned by the organization or person.*/
        public  OwnershipInfo[] owns;
        /*A review of the item.*/
        public  Review[] review;
        /*Review of the item (legacy spelling; see singular form, review).*/
        public  Review[] reviews;
        /*A pointer to products or services sought by the organization or person (demand).*/
        public  Demand[] seeks;
        /*The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.*/
        public  string[] taxID;
        /*The telephone string.*/
        public  string[] telephone;
        /*The value-added Tax ID of the organisation or person.*/
        public  string[] vatID;
    }
}