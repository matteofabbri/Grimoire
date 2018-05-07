using System;

namespace Schema.Net
{
    [Serializable]
    public  class Article : CreativeWork
    {
        /*The actual body of the article.*/
        public  string[] articleBody;
        /*Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.*/
        public  string[] articleSection;
        /*The string of words in the string of the Article.*/
        public  string[] wordCount;
    }
}