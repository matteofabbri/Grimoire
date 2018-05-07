using System;

namespace Schema.Net
{
    [Serializable]
    public  class FoodEstablishment : LocalBusiness
    {
        /*Either Yes/No, or a string at which reservations can be made.*/
        public  string[] acceptsReservations;
        /*Either the actual menu or a string of the menu.*/
        public  string[] menu;
        /*The cuisine of the restaurant.*/
        public  string[] servesCuisine;
    }
}