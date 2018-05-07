using System;

namespace Schema.Net
{
    [Serializable]
    public  class ImageObject : MediaObject
    {
        /*The caption for this object.*/
        public  string[] caption;
        /*exif data for this object.*/
        public  string[] exifData;
        /*Indicates whether this image is representative of the content of the page.*/
        public  string[] representativeOfPage;
        /*Thumbnail image for an image or video.*/
        public  ImageObject[] thumbnail;
    }
}