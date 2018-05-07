using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Netfluid.Access;


namespace Elettra.AccessControl
{
    class StaffAccess:LogIn
    {
        public ObjectId _id { get; set; }

        public ObjectId MemberId { get; set; }

        [BsonIgnore]
        public StaffMember Member
        {
            get
            {
                return StaffManager.ById(MemberId);
            }
        }

        public DateTime SignUp { get; internal set; }
    }
}
