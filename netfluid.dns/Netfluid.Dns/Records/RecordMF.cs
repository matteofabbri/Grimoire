/*
 * 
3.3.5. MF RDATA format (Obsolete)

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                   MADNAME                     /
    /                                               /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

MADNAME         A <domain-name> which specifies a host which has a mail
                agent for the domain which will accept mail for
                forwarding to the domain.

MF records cause additional section processing which looks up an A type
record corresponding to MADNAME.

MF is obsolete.  See the definition of MX and [RFC-974] for details ofw
the new scheme.  The recommended policy for dealing with MD RRs found in
a master file is to reject them, or to convert them to MX RRs with a
preference of 10. */

using System;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record MF
    /// </summary>
    [Serializable]
    public class RecordMf : Record
    {
        [DomainName] public string MadName;

        public override string ToString()
        {
            return MadName;
        }
    }
}