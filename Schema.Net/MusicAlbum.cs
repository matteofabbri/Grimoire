using System;

namespace Schema.Net
{
    [Serializable]
    public  class MusicAlbum : MusicPlaylist
    {
        /*The artist that performed this album or recording.*/
        public  MusicGroup[] byArtist;
    }
}