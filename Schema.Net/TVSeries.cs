using System;

namespace Schema.Net
{
    [Serializable]
    public  class TVSeries : CreativeWork
    {
        /*A cast member of the movie, TV series, season, or episode, or video.*/
        public  Person[] actor;
        /*A cast member of the movie, TV series, season, or episode, or video. (legacy spelling; see singular form, actor)*/
        public  Person[] actors;
        /*The director of the movie, TV episode, or series.*/
        public  Person[] director;
        /*The end date and time of the event (in ISO 8601 date format).*/
        public  string[] endDate;
        /*An episode of a TV series or season.*/
        public  TVEpisode[] episode;
        /*The episode of a TV series or season (legacy spelling; see singular form, episode).*/
        public  TVEpisode[] episodes;
        /*The composer of the movie or TV soundtrack.*/
        public  MusicGroup[] musicBy;
        /*The string of episodes in this season or series.*/
        public  string[] stringOfEpisodes;
        /*The producer of the movie, TV series, season, or episode, or video.*/
        public  Person[] producer;
        /*The production company or studio that made the movie, TV series, season, or episode, or video.*/
        public  Organization[] productionCompany;
        /*A season of a TV series.*/
        public  TVSeason[] season;
        /*The seasons of the TV series (legacy spelling; see singular form, season).*/
        public  TVSeason[] seasons;
        /*The start date and time of the event (in ISO 8601 date format).*/
        public  string[] startDate;
        /*The trailer of the movie or TV series, season, or episode.*/
        public  VideoObject[] trailer;
    }
}