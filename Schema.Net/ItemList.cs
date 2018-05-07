using System;

namespace Schema.Net
{
    [Serializable]
    public  class ItemList : CreativeWork
    {
        /*A single list item.*/
        public  string[] itemListElement;
        /*Type of ordering (e.g. Ascending, Descending, Unordered).*/
        public  string[] itemListOrder;
    }
}