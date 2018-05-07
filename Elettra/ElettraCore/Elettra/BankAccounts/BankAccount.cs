using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Elettra.BankAccounts
{
    public class BankAccount:DBObject
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

        public string IBAN { get; set; }

        public string SWIFT { get; set; }

        public string BankAgency { get; set; }

    }
}
