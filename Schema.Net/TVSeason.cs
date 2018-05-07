using System;

namespace Schema.Net
{
    [Serializable]
    public  class TVSeason : CreativeWork
    {
        /*The end date and time of the event (in ISO 8601 date format).*/
        public  string[] endDate;
        /*An episode of a TV series or season.*/
        public  TVEpisode[] episode;
        /*The episode of a TV series or season (legacy spelling; see singular form, episode).*/
        public  TVEpisode[] episodes;
        /*The string of episodes in this season or series.*/
        public  string[] stringOfEpisodes;
        /*The TV series to which this episode or season belongs.*/
        public  TVSeries[] partOfTVSeries;
        /*The season string.*/
        public  string[] seasonstring;
        /*The start date and time of the event (in ISO 8601 date format).*/
        public  string[] startDate;
        /*The trailer of the movie or TV series, season, or episode.*/
        public  VideoObject[] trailer;
    }
}