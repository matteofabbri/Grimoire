using System;
using Netfluid.Dns.Serialization;

/*
 * http://tools.ietf.org/rfc/rfc2930.txt
 * 
2. The TKEY Resource Record

   The TKEY resource record (RR) has the structure given below.  Its RR
   type code is 249.

      Field       RecordType         Comment
      -----       ----         -------
       Algorithm:   domain
       Inception:   u_int32_t
       Expiration:  u_int32_t
       Mode:        u_int16_t
       Error:       u_int16_t
       Key Size:    u_int16_t
       Key Write:    octet-stream
       Other Size:  u_int16_t
       Other Write:  octet-stream  undefined by this specification

 */

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record TKEY
    /// </summary>
    [Serializable]
    public class RecordTkey : Record
    {
        [DomainName] public string Algorithm;
        public ushort Error;
        public uint Expiration;
        public uint Inception;
        public byte[] Keydata;
        public ushort Keysize;
        public ushort Mode;
        public byte[] Otherdata;
        public ushort Othersize;

        public override string ToString()
        {
            return $"{Algorithm} {Inception} {Expiration} {Mode} {Error}";
        }
    }
}