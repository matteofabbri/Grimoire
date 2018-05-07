using System;

namespace Schema.Net
{
    [Serializable]
    public  class Movie : CreativeWork
    {
        /*A cast member of the movie, TV series, season, or episode, or video.*/
        public  Person[] actor;
        /*A cast member of the movie, TV series, season, or episode, or video. (legacy spelling; see singular form, actor)*/
        public  Person[] actors;
        /*The director of the movie, TV episode, or series.*/
        public  Person[] director;
        /*The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.*/
        public  string[] duration;
        /*The composer of the movie or TV soundtrack.*/
        public  MusicGroup[] musicBy;
        /*The producer of the movie, TV series, season, or episode, or video.*/
        public  Person[] producer;
        /*The production company or studio that made the movie, TV series, season, or episode, or video.*/
        public  Organization[] productionCompany;
        /*The trailer of the movie or TV series, season, or episode.*/
        public  VideoObject[] trailer;
    }
}