using System;

namespace Schema.Net
{
    [Serializable]
    public  class TVEpisode : CreativeWork
    {
        /*A cast member of the movie, TV series, season, or episode, or video.*/
        public  Person[] actor;
        /*A cast member of the movie, TV series, season, or episode, or video. (legacy spelling; see singular form, actor)*/
        public  Person[] actors;
        /*The director of the movie, TV episode, or series.*/
        public  Person[] director;
        /*The episode string.*/
        public  string[] episodestring;
        /*The composer of the movie or TV soundtrack.*/
        public  MusicGroup[] musicBy;
        /*The season to which this episode belongs.*/
        public  TVSeason[] partOfSeason;
        /*The TV series to which this episode or season belongs.*/
        public  TVSeries[] partOfTVSeries;
        /*The producer of the movie, TV series, season, or episode, or video.*/
        public  Person[] producer;
        /*The production company or studio that made the movie, TV series, season, or episode, or video.*/
        public  Organization[] productionCompany;
        /*The trailer of the movie or TV series, season, or episode.*/
        public  VideoObject[] trailer;
    }
}