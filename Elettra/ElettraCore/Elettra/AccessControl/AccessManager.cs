using MongoDB.Driver;
using System;
using System.Linq;

namespace Elettra.AccessControl
{
    class AccessManager
    {
        static IMongoCollection<StaffAccess> repository;

        static AccessManager()
        {
            repository = Program.Database.GetCollection<StaffAccess>("staffAccess");
        }

        public static StaffAccess NewAccess(StaffMember member,string username, string password)
        {
            var access = new StaffAccess
            {
                MemberId = member._id,
                UserName = username,
                Domain = string.Empty,
                DomainAdmin = false,
                GlobalAdmin = false,
                SignUp = DateTime.Now,
                LastLogin = DateTime.Now,
                LastModify = DateTime.Now
            };

            access.ChangePassword(password);

            repository.InsertOneAsync(access).Wait();

            return access;
        }

        public static StaffAccess SignIn(string username, string password)
        {
            var user = Get(username);

            if (user == null || !user.SignIn(password)) return null;

            user.LastLogin = DateTime.Now;

            repository.UpdateOneAsync(x => x._id == user._id,Builders<StaffAccess>.Update.Set(x=>x.LastLogin,DateTime.Now));

            return user;
        }

        public static int Count { get; internal set; }

        public static StaffAccess Get(string username)
        {
            return repository.Find(x => x.UserName == username).FirstOrDefault();
        }
    }
}
