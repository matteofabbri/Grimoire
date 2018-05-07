using System;

namespace Schema.Net
{
    [Serializable]
    public  class Dataset : CreativeWork
    {
        /*A data catalog which contains a dataset.*/
        public  DataCatalog[] catalog;
        /*A downloadable form of this dataset, at a specific location, in a specific format.*/
        public  DataDownload[] distribution;
        /*The range of spatial applicability of a dataset, e.g. for a dataset of New York weather, the state of New York.*/
        public  Place[] spatial;
        /*The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).*/
        public  string[] temporal;
    }
}