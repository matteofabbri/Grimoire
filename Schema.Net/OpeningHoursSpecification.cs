using System;

namespace Schema.Net
{
    [Serializable]
    public  class OpeningHoursSpecification : StructuredValue
    {
        /*The closing hour of the place or service on the given day(s) of the week.*/
        public  string[] closes;
        /*The day of the week for which these opening hours are valid.*/
        public  DayOfWeek[] dayOfWeek;
        /*The opening hour of the place or service on the given day(s) of the week.*/
        public  string[] opens;
        /*The beginning of the validity of offer, price specification, or opening hours data.*/
        public  string[] validFrom;
        /*The end of the validity of offer, price specification, or opening hours data.*/
        public  string[] validThrough;
    }
}