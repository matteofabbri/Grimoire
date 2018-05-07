using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elettra
{
    public class Message
    {
        public string SenderId { get; set; }

        [BsonIgnore]
        public StaffMember Sender
        {
            get
            {
                return StaffManager.ById(SenderId);
            }
        }

        public string RecipientId { get; set; }

        [BsonIgnore]
        public StaffMember Recipient
        {
            get
            {
                return StaffManager.ById(SenderId);
            }
        }

        public DateTime Timestamp { get; set; }

        public bool Read { get; set; }

        public string Text { get; set; }

        public string TextPreview { get; set; }
    }
}
