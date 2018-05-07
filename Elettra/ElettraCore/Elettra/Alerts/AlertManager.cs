using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Elettra.Alerts
{
    class AlertManager
    {
        static IMongoCollection<Alert> repository;

        static AlertManager()
        {
            repository = Program.Database.GetCollection<Alert>("alerts");

            if (repository.Count(Builders<Alert>.Filter.Empty) == 0)
            {
                New("ciaooooooooo", StaffManager.Admin, StaffManager.Admin, StaffManager.Admin);
            }
        }

        public static void New(string message, params StaffMember[] to)
        {
            foreach (var item in to)
            {
                var m = new Alert
                {
                    Read = false,
                    ToId = item._id,
                    Text = message,
                    Timestamp = DateTime.Now,
                    Icon = "star"
                };
                repository.InsertOneAsync(m);
            }
        }

        public static IEnumerable<Alert> To(StaffMember to)
        {
            var filter = Builders<Alert>.Filter.Eq(x => x.ToId, to._id);
            var res = new List<Alert>();
            repository.Find(filter).SortByDescending(x => x.Timestamp).ForEachAsync(x => res.Add(x)).Wait();
            return res;
        }
    }
}
