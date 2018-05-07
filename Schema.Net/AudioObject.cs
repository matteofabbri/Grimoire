using System;

namespace Schema.Net
{
    [Serializable]
    public  class AudioObject : MediaObject
    {
        /*If this MediaObject is an AudioObject or VideoObject, the transcript of that object.*/
        public  string[] transcript;
    }
}