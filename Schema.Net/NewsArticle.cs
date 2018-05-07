using System;

namespace Schema.Net
{
    [Serializable]
    public  class NewsArticle : Article
    {
        /*The location where the NewsArticle was produced.*/
        public  string[] dateline;
        /*The string of the column in which the NewsArticle appears in the print edition.*/
        public  string[] printColumn;
        /*The edition of the print product in which the NewsArticle appears.*/
        public  string[] printEdition;
        /*If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).*/
        public  string[] printPage;
        /*If this NewsArticle appears in print, this field indicates the print section in which the article appeared.*/
        public  string[] printSection;
    }
}