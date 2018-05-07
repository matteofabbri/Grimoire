using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Netfluid;

namespace Elettra
{
    public class Address:DBObject
    {
        public ObjectId PersonId { get; set; }

        [BsonIgnore]
        public Person Person
        {
            get { return PeopleManger.ById(PersonId); }
            set { PersonId = value._id; }
        }

        public ObjectId CompanyId { get; set; }

        [BsonIgnore]
        public Company Company
        {
            get { return CompanyManger.ById(PersonId); }
            set { CompanyId = value._id; }
        }

        public CountryCode CountryCode { get; set; }

        [BsonIgnore]
        public Country Country
        {
            get
            {
                return Country.FromCode(CountryCode);
            }
            set
            {
                CountryCode = value.CountryCode;
            }
        }

        public string Region { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Street { get; set; }
    }
}
