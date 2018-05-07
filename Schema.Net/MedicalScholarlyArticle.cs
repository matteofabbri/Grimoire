using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalScholarlyArticle : ScholarlyArticle
    {
        /*A citation or reference to another creative work, such as another publication, web page, scholarly article, etc. NOTE: Candidate for promotion to ScholarlyArticle.*/
        public  CreativeWork[] citation;
        /*The type of the medical article, taken from the US NLM MeSH publication type catalog.*/
        public  string[] publicationType;
    }
}