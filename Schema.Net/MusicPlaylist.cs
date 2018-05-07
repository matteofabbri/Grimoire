using System;

namespace Schema.Net
{
    [Serializable]
    public  class MusicPlaylist : CreativeWork
    {
        /*The string of tracks in this album or playlist.*/
        public  string[] numTracks;
        /*A music recording (track)&#x2014;usually a single song.*/
        public  MusicRecording[] track;
        /*A music recording (track)&#x2014;usually a single song (legacy spelling; see singular form, track).*/
        public  MusicRecording[] tracks;
    }
}