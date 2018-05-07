using System;

namespace Schema.Net
{
    [Serializable]
    public  class CreativeWork : Thing
    {
        /*The subject matter of the content.*/
        public  Thing[] about;
        /*Specifies the Person that is legally accountable for the CreativeWork.*/
        public  Person[] accountablePerson;
        /*The overall rating, based on a collection of reviews or ratings, of the item.*/
        public  AggregateRating[] aggregateRating;
        /*A secondary title of the CreativeWork.*/
        public  string[] alternativeHeadline;
        /*The media objects that encode this creative work. This property is a synonym for encodings.*/
        public  MediaObject[] associatedMedia;
        /*The intended audience of the item, i.e. the group for whom the item was created.*/
        public  Audience[] audience;
        /*An embedded audio object.*/
        public  AudioObject[] audio;
        /*The author of this content. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.*/
        public  Organization[] author;
        /*An award won by this person or for this creative work.*/
        public  string[] award;
        /*Awards won by this person or for this creative work. (legacy spelling; see singular form, award)*/
        public  string[] awards;
        /*Comments, typically from users, on this CreativeWork.*/
        public  UserComments[] comment;
        /*The location of the content.*/
        public  Place[] contentLocation;
        /*Official rating of a piece of content&#x2014;for example,'MPAA PG-13'.*/
        public  string[] contentRating;
        /*A secondary contributor to the CreativeWork.*/
        public  Organization[] contributor;
        /*The party holding the legal copyright to the CreativeWork.*/
        public  Organization[] copyrightHolder;
        /*The year during which the claimed copyright for the CreativeWork was first asserted.*/
        public  string[] copyrightYear;
        /*The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.*/
        public  Organization[] creator;
        /*The date on which the CreativeWork was created.*/
        public  string[] dateCreated;
        /*The date on which the CreativeWork was most recently modified.*/
        public  string[] dateModified;
        /*string of first broadcast/publication.*/
        public  string[] datePublished;
        /*A link to the page containing the comments of the CreativeWork.*/
        public  string[] discussionUrl;
        /*Specifies the Person who edited the CreativeWork.*/
        public  Person[] editor;
        /*An alignment to an established educational framework.*/
        public  AlignmentObject[] educationalAlignment;
        /*The purpose of a work in the constring of education; for example, 'assignment', 'group work'.*/
        public  string[] educationalUse;
        /*A media object that encode this CreativeWork.*/
        public  MediaObject[] encoding;
        /*The media objects that encode this creative work (legacy spelling; see singular form, encoding).*/
        public  MediaObject[] encodings;
        /*Genre of the creative work*/
        public  string[] genre;
        /*Headline of the article*/
        public  string[] headline;
        /*The language of the content. please use one of the language codes from the IETF BCP 47 standard.*/
        public  string[] inLanguage;
        /*A count of a specific user interactions with this item&#x2014;for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.*/
        public  string[] interactionCount;
        /*The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.*/
        public  string[] interactivityType;
        /*A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html*/
        public  string[] isBasedOnUrl;
        /*Indicates whether this content is family friendly.*/
        public  string[] isFamilyFriendly;
        /*The keywords/tags used to describe this content.*/
        public  string[] keywords;
        /*The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.*/
        public  string[] learningResourceType;
        /*Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.*/
        public  Thing[] mentions;
        /*An offer to sell this item&#x2014;for example, an offer to sell a product, the DVD of a movie, or tickets to an event.*/
        public  Offer[] offers;
        /*Specifies the Person or Organization that distributed the CreativeWork.*/
        public  Organization[] provider;
        /*The publisher of the creative work.*/
        public  Organization[] publisher;
        /*Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.*/
        public  string[] publishingPrinciples;
        /*A review of the item.*/
        public  Review[] review;
        /*Review of the item (legacy spelling; see singular form, review).*/
        public  Review[] reviews;
        /*The Organization on whose behalf the creator was working.*/
        public  Organization[] sourceOrganization;
        /*The textgual content of this CreativeWork.*/
        public  string[] text;
        /*A thumbnail image relevant to the Thing.*/
        public  string[] thumbnailUrl;
        /*Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.*/
        public  string[] timeRequired;
        /*The typical range of ages the content's intendedEndUser, for example '7-9', '11-'.*/
        public  string[] typicalAgeRange;
        /*The version of the CreativeWork embodied by a specified resource.*/
        public  string[] version;
        /*An embedded video object.*/
        public  VideoObject[] video;
    }
}