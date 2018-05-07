using System;

namespace Schema.Net
{
    [Serializable]
    public  class DataCatalog : CreativeWork
    {
        /*A dataset contained in a catalog.*/
        public  Dataset[] dataset;
    }
}