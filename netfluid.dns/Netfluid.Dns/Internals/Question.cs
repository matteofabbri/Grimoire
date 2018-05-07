using System;

namespace Netfluid.Dns.Internals
{
    #region Rfc 1034/1035

    /*
	4.1.2. Question section format

	The question section is used to carry the "question" in most queries,
	i.e., the parameters that define what is being asked.  The section
	contains QDCOUNT (usually 1) entries, each of the following format:

										1  1  1  1  1  1
		  0  1  2  3  4  5  6  7  8  9  0  1  2  3  4  5
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
		|                                               |
		/                     QNAME                     /
		/                                               /
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
		|                     QTYPE                     |
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
		|                     QCLASS                    |
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

	where:

	QNAME           a domain name represented as a sequence of labels, where
					each label consists of a length octet followed by that
					number of octets.  The domain name terminates with the
					zero length octet for the null label of the root.  Note
					that this field may be an odd number of octets; no
					padding is used.

	QTYPE           a two octet code which specifies the type of the query.
					The values for this field include all codes valid for a
					TYPE field, together with some more general codes which
					can match more than one type of RR.


	QCLASS          a two octet code that specifies the class of the query.
					For example, the QCLASS field is IN for the Internet.
	*/

    #endregion

    /// <summary>
    ///     DNS query used by DNS server and resolver
    /// </summary>
    [Serializable]
    internal class Question
    {
        /// <summary>
        ///     Address class (Internet, CSNET, CHAOS, HESIOD, ANY)
        /// </summary>
        public RecordClass Class;

        /// <summary>
        ///     Domain of the query
        /// </summary>
        public string Name;

        /// <summary>
        ///     Requested records type
        /// </summary>
        public RecordType Type;

        /// <summary>
        ///     Create a new DNS question
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="qclass"></param>
        public Question(string name, RecordType type, RecordClass qclass)
        {
            Name = name;
            Type = type;
            Class = qclass;
        }

        public override string ToString()
        {
            return string.Format($"{Name,-32}\t{Class}\t{Type}");
        }
    }
}