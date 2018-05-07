using MongoDB.Bson;
using System.Linq;

namespace Elettra
{
    public class DBObject
    {
        public ObjectId _id { get; set; }

        public string FullText
        {
            get
            {
                var s = GetType()
                 .GetProperties()
                 .Where(x => x.PropertyType == typeof(string) && x.Name != "FullText")
                 .Select(x => x.GetValue(this))
                 .Where(x => x != null)
                 .Select(x => x.ToString());

                return string.Join(" ", s);
            }
            set { }
        }
    }
}