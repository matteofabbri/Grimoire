using System;

namespace Schema.Net
{
    [Serializable]
    public  class MediaObject : CreativeWork
    {
        /*A NewsArticle associated with the Media Object.*/
        public  NewsArticle[] associatedArticle;
        /*The bitrate of the media object.*/
        public  string[] bitrate;
        /*File size in (mega/kilo) bytes.*/
        public  string[] contentSize;
        /*Actual bytes of the media object, for example the image file or video file. (previous spelling: contentURL)*/
        public  string[] contentUrl;
        /*The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.*/
        public  string[] duration;
        /*A string pointing to a player for a specific video. In general, this is the information in the src element of an embed tag and should not be the same as the content of the loc tag. (previous spelling: embedURL)*/
        public  string[] embedUrl;
        /*The creative work encoded by this media object*/
        public  CreativeWork[] encodesCreativeWork;
        /*mp3, mpeg4, etc.*/
        public  string[] encodingFormat;
        /*string the content expires and is no longer useful or available. Useful for videos.*/
        public  string[] expires;
        /*The height of the item.*/
        public  string[] height;
        /*Player type required&#x2014;for example, Flash or Silverlight.*/
        public  string[] playerType;
        /*The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in ISO 3166 format.*/
        public  Place[] regionsAllowed;
        /*Indicates if use of the media require a subscription  (either paid or free). Allowed values are true or false (note that an earlier version had 'yes', 'no').*/
        public  string[] requiresSubscription;
        /*string when this media object was uploaded to this site.*/
        public  string[] uploadDate;
        /*The width of the item.*/
        public  string[] width;
    }
}