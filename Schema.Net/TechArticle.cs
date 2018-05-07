using System;

namespace Schema.Net
{
    [Serializable]
    public  class TechArticle : Article
    {
        /*Prerequisites needed to fulfill steps in article.*/
        public  string[] dependencies;
        /*Proficiency needed for this content; expected values: 'Beginner', 'Expert'.*/
        public  string[] proficiencyLevel;
    }
}