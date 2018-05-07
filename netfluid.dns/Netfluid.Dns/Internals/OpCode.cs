using System;

namespace Netfluid.Dns.Internals
{
    /*
 * http://www.iana.org/assignments/dns-parameters
 * 
 * 
 * 
 */
    /*
OPCODE          A four bit field that specifies kind of query in this
                message.  This value is set by the originator of a query
                and copied into the response.  The values are:

                0               a standard query (QUERY)

                1               an inverse query (IQUERY)

                2               a server status request (STATUS)

                3-15            reserved for future use
	 */

    /// <summary>
    ///     DNS protocol query code
    /// </summary>
    [Serializable]
    internal enum OpCode
    {
        Query = 0, // a standard query (QUERY)
        IQUERY = 1, // OpCode Retired (previously IQUERY - No further [RFC3425]

        // assignment of this code available)
        Status = 2, // a server status request (STATUS) RFC1035
        RESERVED3 = 3, // IANA

        Notify = 4, // RFC1996
        Update = 5, // RFC2136

        RESERVED6 = 6,
        RESERVED7 = 7,
        RESERVED8 = 8,
        RESERVED9 = 9,
        RESERVED10 = 10,
        RESERVED11 = 11,
        RESERVED12 = 12,
        RESERVED13 = 13,
        RESERVED14 = 14,
        RESERVED15 = 15
    }
}