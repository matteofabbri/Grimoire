using System;
using Netfluid.Dns.Serialization;

namespace Netfluid.Dns.Records
{
    /*
	3.3.9. MX RDATA format

		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
		|                  PREFERENCE                   |
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
		/                   EXCHANGE                    /
		/                                               /
		+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

	where:

	PREFERENCE      A 16 bit integer which specifies the preference given to
					this RR among others at the same owner.  Lower values
					are preferred.

	EXCHANGE        A <domain-name> which specifies a host willing to act as
					a mail exchange for the owner name.

	MX records cause type A additional section processing for the host
	specified by EXCHANGE.  The use of MX RRs is explained in detail in
	[RFC-974].
	*/

    /// <summary>
    ///     DNS record MX
    /// </summary>
    [Serializable]
    public class RecordMx : Record, IComparable
    {
        [DomainName] public string Exchange;
        public ushort Preference;

        public int CompareTo(object objA)
        {
            var recordMx = objA as RecordMx;
            if (recordMx == null)
                return -1;
            if (Preference > recordMx.Preference)
                return 1;
            if (Preference < recordMx.Preference)
                return -1;
            return string.Compare(Exchange, recordMx.Exchange, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Preference} {Exchange}";
        }

        public static RecordMx Parse(string s)
        {
            return new RecordMx {Exchange = s, Preference = 20};
        }

        public static implicit operator RecordMx(string s)
        {
            return new RecordMx {Exchange = s, Preference = 20};
        }
    }
}