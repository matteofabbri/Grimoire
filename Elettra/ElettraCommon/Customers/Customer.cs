using Netfluid;
using System;
using System.Collections.Generic;

namespace Elettra
{
    public class Customer : DBObject
    {
        public Customer()
        {
            LastContact = DateTime.Now;
            FirstContact = DateTime.Now;
        }

        public string Source { get; set; }

        public DateTime FirstContact { get; set; }

        public DateTime LastContact { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public CountryCode CountryCode { get; set; }

        public Country Country
        {
            get
            {
                return Country.FromCode(CountryCode);
            }
        }

        public string Region { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Street { get; set; }

        public string BirthPlace { get; set; }

        public DateTime BirthDay { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime DocumentExpiration { get; set; }

        public DocumentType DocumentType { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public static Customer Parse(string id)
        {
            return null;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
