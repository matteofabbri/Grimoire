using System;

namespace Schema.Net
{
    [Serializable]
    public  class WebPage : CreativeWork
    {
        /*A set of links that can help a user understand and navigate a website hierarchy.*/
        public  string[] breadcrumb;
        /*Indicates the collection or gallery to which the item belongs.*/
        public  CollectionPage[] isPartOf;
        /*string on which the content on this web page was last reviewed for accuracy and/or completeness.*/
        public  string[] lastReviewed;
        /*Indicates if this web page element is the main subject of the page.*/
        public  WebPageElement[] mainContentOfPage;
        /*Indicates the main image on the page*/
        public  ImageObject[] primaryImageOfPage;
        /*A link related to this web page, for example to other related web pages.*/
        public  string[] relatedLink;
        /*People or organizations that have reviewed the content on this web page for accuracy and/or completeness.*/
        public  Organization[] reviewedBy;
        /*One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.*/
        public  string[] significantLink;
        /*The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most (legacy spelling; see singular form, significantLink).*/
        public  string[] significantLinks;
        /*One of the domain specialities to which this web page's content applies.*/
        public  Specialty[] specialty;
    }
}