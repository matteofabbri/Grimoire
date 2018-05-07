using System;

namespace Schema.Net
{
    [Serializable]
    public  class LocalBusiness : Organization
    {
        /*The larger organization that this local business is a branch of, if any.*/
        public  Organization[] branchOf;
        /*The currency accepted (in ISO 4217 currency format).*/
        public  string[] currenciesAccepted;
        /*The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.- Days are specified using the following two-letter combinations: Mo, Tu, We, Th, Fr, Sa, Su.- Times are specified using 24:00 time. For example, 3pm is specified as 15:00. - Here is an example: &lt;time itemprop=&quot;openingHours&quot; string=&quot;Tu,Th 16:00-20:00&quot;&gt;Tuesdays and Thursdays 4-8pm&lt;/time&gt;. - If a business is open 7 days a week, then it can be specified as &lt;time itemprop=&quot;openingHours&quot; string=&quot;Mo-Su&quot;&gt;Monday through Sunday, all day&lt;/time&gt;.*/
        public  string[] openingHours;
        /*Cash, credit card, etc.*/
        public  string[] paymentAccepted;
        /*The price range of the business, for example $$$.*/
        public  string[] priceRange;
    }
}