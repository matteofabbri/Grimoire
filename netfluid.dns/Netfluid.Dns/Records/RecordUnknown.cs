using System;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     Undetected / unsupported DNS record type
    /// </summary>
    [Serializable]
    public class RecordUnknown : Record
    {
        public byte[] Rdata;
    }
}