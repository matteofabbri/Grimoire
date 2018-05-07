using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Elettra
{
    class AddressManager
    {
        static IMongoCollection<Address> repository;

        static AddressManager()
        {
            repository = Program.Database.GetCollection<Address>("addresses");
            repository.Indexes.CreateOne(Builders<Address>.IndexKeys.Text(x => x.FullText));
        }

        public static long Count
        {
            get
            {
                return repository.Count(Builders<Address>.Filter.Empty);
            }
        }

        public static Address Add(Address add)
        {
            add._id = ObjectId.Empty;
            repository.InsertOne(add);
            return add;
        }

        internal static IEnumerable<Address> ByText(string s)
        {
            var r = repository.Find(Builders<Address>.Filter.Text(s));
            var list = new List<Address>();
            r.ForEachAsync(x => list.Add(x)).Wait();
            return list;
        }

        internal static IEnumerable<Address> ByPerson(Person person)
        {
            var r = repository.Find(Builders<Address>.Filter.Eq(x=>x.PersonId,person._id));
            var list = new List<Address>();
            r.ForEachAsync(x => list.Add(x)).Wait();
            return list;
        }
    }
}
