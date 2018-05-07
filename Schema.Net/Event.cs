using System;

namespace Schema.Net
{
    [Serializable]
    public  class Event : Thing
    {
        /*A person or organization attending the event.*/
        public  Organization[] attendee;
        /*A person attending the event (legacy spelling; see singular form, attendee).*/
        public  Organization[] attendees;
        /*The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.*/
        public  string[] duration;
        /*The end date and time of the event (in ISO 8601 date format).*/
        public  string[] endDate;
        /*The location of the event or organization.*/
        public  Place[] location;
        /*An offer to sell this item&#x2014;for example, an offer to sell a product, the DVD of a movie, or tickets to an event.*/
        public  Offer[] offers;
        /*A performer at the event&#x2014;for example, a presenter, musician, musical group or actor.*/
        public  Organization[] performer;
        /*The main performer or performers of the event&#x2014;for example, a presenter, musician, or actor (legacy spelling; see singular form, performer).*/
        public  Organization[] performers;
        /*The start date and time of the event (in ISO 8601 date format).*/
        public  string[] startDate;
        /*An Event that is part of this event. For example, a conference event includes many presentations, each are a subEvent of the conference.*/
        public  Event[] subEvent;
        /*Events that are a part of this event. For example, a conference event includes many presentations, each are subEvents of the conference (legacy spelling; see singular form, subEvent).*/
        public  Event[] subEvents;
        /*An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.*/
        public  Event[] superEvent;
    }
}