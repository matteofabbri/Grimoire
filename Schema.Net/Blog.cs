using System;

namespace Schema.Net
{
    [Serializable]
    public  class Blog : CreativeWork
    {
        /*A posting that is part of this blog.*/
        public  BlogPosting[] blogPost;
        /*The postings that are part of this blog (legacy spelling; see singular form, blogPost).*/
        public  BlogPosting[] blogPosts;
    }
}