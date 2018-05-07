using System;
using Netfluid.Dns.Serialization;

/*
 * http://www.ietf.org/rfc/rfc2845.txt
 * 
 * Field Name       Write RecordType      Notes
      --------------------------------------------------------------
      Algorithm Name   domain-name    Name of the algorithm
                                      in domain name syntax.
      Time Signed      u_int48_t      seconds since 1-Jan-70 UTC.
      Fudge            u_int16_t      seconds of error permitted
                                      in Time Signed.
      MAC Size         u_int16_t      number of octets in MAC.
      MAC              octet stream   defined by Algorithm Name.
      Original ID      u_int16_t      original message ID
      Error            u_int16_t      expanded RCODE covering
                                      TSIG processing.
      Other Len        u_int16_t      length, in octets, of
                                      Other Write.
      Other Write       octet stream   empty unless Error == BADTIME

 */

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record TSIG
    /// </summary>
    [Serializable]
    public class RecordTsig : Record
    {
        [DomainName] public string Algorithmname;
        public ushort Error;
        public ushort Fudge;
        public byte[] Mac;
        public ushort Macsize;
        public ushort Originalid;
        public byte[] Otherdata;
        public ushort Otherlen;
        public long Timesigned;

        public override string ToString()
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(Timesigned);
            var printDate = dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
            return $"{Algorithmname} {printDate} {Fudge} {Originalid} {Error}";
        }
    }
}