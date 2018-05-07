// Stuff records are made of

using System;
using System.Collections.Generic;
using System.Linq;
using Netfluid.Dns.Internals;
using Netfluid.Dns.Records;

namespace Netfluid.Dns
{
    /// <summary>
    ///     DNS record base class
    /// </summary>
    [Serializable]
    public class Record
    {
        /// <summary>
        ///     Specifies type class of resource record, mostly IN but can be CS, CH or HS
        /// </summary>
        public RecordClass Class;

        /// <summary>
        ///     The name of the node to which this resource record pertains
        /// </summary>
        public string Name;

        /// <summary>
        ///     Time lived
        /// </summary>
        public int TimeLived;

        static Record()
        {
            Types = typeof(Record).Assembly.GetTypes().Where(x => x.Inherit(typeof(Record))).ToArray();
        }

        /// <summary>
        ///     Create a new generic DNS record
        /// </summary>
        public Record()
        {
            TimeLived = 0;
            Name = "netfluid.org";
            Class = RecordClass.IN;
            TTL = 65536;
        }

        public static Type[] Types { get; }

        /// <summary>
        ///     Time to live, the time interval that the resource record may be cached
        /// </summary>
        public uint TTL { get; set; }

        /// <summary>
        ///     Return the type of this record as RecordType enum
        /// </summary>
        public RecordType RecordType => (RecordType) Enum.Parse(typeof(RecordType),
            GetType().Name.Substring("Record".Length));

        /// <summary>
        ///     Zone parts of the domain (www.example.com, .example.com, .com)
        /// </summary>
        public string[] Zones
        {
            get
            {
                var list = new List<string>();
                var parts = Name.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

                for (var i = 0; i < parts.Length; i++)
                {
                    var zone = string.Join(".", parts.Take(i + 1).Reverse());
                    list.Add(zone);
                }
                return list.ToArray();
            }
        }

        /// <summary>
        ///     Return .net type of record from enum RecordType
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type Type(RecordType type)
        {
            return Types.FirstOrDefault(x => x.Name == "Record" + type.ToString()) ?? typeof(RecordUnknown);
        }

        /// <summary>
        ///     Instance a new record from the given type
        /// </summary>
        /// <param name="type">Record type enum or Type casted</param>
        /// <returns>new record of the given type</returns>
        public static Record FromType(RecordType type)
        {
            return Types.FirstOrDefault(x => x.Name == "Record" + type.ToString()).CreateIstance() as Record ??
                   new RecordUnknown();
        }
    }
}