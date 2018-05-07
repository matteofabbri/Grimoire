using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Elettra.BankAccounts
{
    class BankAccountManager
    {
        static IMongoCollection<BankAccount> repository;

        static BankAccountManager()
        {
            repository = Program.Database.GetCollection<BankAccount>("bankAccounts");
            repository.Indexes.CreateOne(Builders<BankAccount>.IndexKeys.Text(x => x.FullText));
        }

        public static long Count
        {
            get
            {
                return repository.Count(Builders<BankAccount>.Filter.Empty);
            }
        }

        public static BankAccount Add(BankAccount add)
        {
            add._id = ObjectId.Empty;
            repository.InsertOne(add);
            return add;
        }

        internal static IEnumerable<BankAccount> ByText(string s)
        {
            var r = repository.Find(Builders<BankAccount>.Filter.Text(s));
            var list = new List<BankAccount>();
            r.ForEachAsync(x => list.Add(x)).Wait();
            return list;
        }

        internal static IEnumerable<BankAccount> ByPerson(Person person)
        {
            var r = repository.Find(Builders<BankAccount>.Filter.Eq(x => x.PersonId, person._id));
            var list = new List<BankAccount>();
            r.ForEachAsync(x => list.Add(x)).Wait();
            return list;
        }

    }
}
