using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Elettra
{
    public class Alert : DBObject
    {
        public ObjectId ToId { get; set; }

        [BsonIgnore]
        public StaffMember To
        {
            get
            {
                return StaffManager.ById(ToId);
            }
        }

        public DateTime Timestamp { get; set; }

        public string Icon { get; set; }

        public bool Read { get; set; }

        public string Text { get; set; }

        public string Link { get; set; }

        [BsonIgnore]
        public string TimeDelta
        {
            get
            {
                var ts = DateTime.Now - Timestamp;

                if (ts.TotalMinutes < 60) return $"{(int)ts.TotalMinutes} min.";
                if (ts.TotalHours < 24) return $"{(int)ts.TotalHours} h.";
                if (ts.TotalDays < 31) return $"{(int)ts.TotalDays} d.";
                if (ts.TotalDays < 365) return $"{(int)(ts.TotalDays / 31)} m.";

                return $"{ts.TotalDays / 365} y.";
            }
        }
    }
}
