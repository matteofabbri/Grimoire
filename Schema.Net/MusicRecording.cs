using System;

namespace Schema.Net
{
    [Serializable]
    public  class MusicRecording : CreativeWork
    {
        /*The artist that performed this album or recording.*/
        public  MusicGroup[] byArtist;
        /*The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.*/
        public  string[] duration;
        /*The album to which this recording belongs.*/
        public  MusicAlbum[] inAlbum;
        /*The playlist to which this recording belongs.*/
        public  MusicPlaylist[] inPlaylist;
    }
}