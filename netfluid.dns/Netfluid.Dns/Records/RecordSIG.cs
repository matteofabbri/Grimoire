using System;
using Netfluid.Dns.Serialization;

#region Rfc info

/*
 * http://www.ietf.org/rfc/rfc2535.txt
 * 4.1 SIG RDATA Format

   The RDATA portion of a SIG RR is as shown below.  The integrity of
   the RDATA information is protected by the signature field.

                           1 1 1 1 1 1 1 1 1 1 2 2 2 2 2 2 2 2 2 2 3 3
       0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
      |        type covered           |  algorithm    |     labels    |
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
      |                         original TTL                          |
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
      |                      signature expiration                     |
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
      |                      signature inception                      |
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
      |            key  tag           |                               |
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+         signer's name         +
      |                                                               /
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-/
      /                                                               /
      /                            signature                          /
      /                                                               /
      +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+


*/

#endregion

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record SIG
    /// </summary>
    [Serializable]
    public class RecordSig : Record
    {
        public byte Algorithm;
        public ushort Keytag;
        public byte Labels;
        public uint Originalttl;
        public string Signature;
        public uint Signatureexpiration;
        public uint Signatureinception;

        [DomainName] public string Signersname;
        public ushort Typecovered;

        public override string ToString()
        {
            return
                $"{Typecovered} {Algorithm} {Labels} {Originalttl} {Signatureexpiration} {Signatureinception} {Keytag} {Signersname} \"{Signature}\"";
        }
    }
}