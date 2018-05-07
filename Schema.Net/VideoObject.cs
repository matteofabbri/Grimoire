using System;

namespace Schema.Net
{
    [Serializable]
    public  class VideoObject : MediaObject
    {
        /*The caption for this object.*/
        public  string[] caption;
        /*The production company or studio that made the movie, TV series, season, or episode, or video.*/
        public  Organization[] productionCompany;
        /*Thumbnail image for an image or video.*/
        public  ImageObject[] thumbnail;
        /*If this MediaObject is an AudioObject or VideoObject, the transcript of that object.*/
        public  string[] transcript;
        /*The frame size of the video.*/
        public  string[] videoFrameSize;
        /*The quality of the video.*/
        public  string[] videoQuality;
    }
}