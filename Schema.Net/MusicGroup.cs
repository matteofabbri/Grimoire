using System;

namespace Schema.Net
{
    [Serializable]
    public  class MusicGroup : PerformingGroup
    {
        /*A music album.*/
        public  MusicAlbum[] album;
        /*A collection of music albums (legacy spelling; see singular form, album).*/
        public  MusicAlbum[] albums;
        /*A member of the music group&#x2014;for example, John, Paul, George, or Ringo.*/
        public  Person[] musicGroupMember;
        /*A music recording (track)&#x2014;usually a single song.*/
        public  MusicRecording[] track;
        /*A music recording (track)&#x2014;usually a single song (legacy spelling; see singular form, track).*/
        public  MusicRecording[] tracks;
    }
}