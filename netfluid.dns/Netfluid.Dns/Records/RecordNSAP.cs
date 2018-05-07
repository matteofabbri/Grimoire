using System;
using System.Text;

/*
 * http://tools.ietf.org/rfc/rfc1348.txt  
 * http://tools.ietf.org/html/rfc1706
 * 
 *	          |--------------|
              | <-- IDP -->  |
              |--------------|-------------------------------------|
              | AFI |  IDI   |            <-- DSP -->              |
              |-----|--------|-------------------------------------|
              | 47  |  0005  | DFI | AA |Rsvd | RD |Area | ID |Sel |
              |-----|--------|-----|----|-----|----|-----|----|----|
       octets |  1  |   2    |  1  | 3  |  2  | 2  |  2  | 6  | 1  |
              |-----|--------|-----|----|-----|----|-----|----|----|

                    IDP    Initial Domain Part
                    AFI    Authority and Format Identifier
                    IDI    Initial Domain Identifier
                    DSP    Domain Specific Part
                    DFI    DSP Format Identifier
                    AA     Administrative Authority
                    Rsvd   Reserved
                    RD     Routing Domain Identifier
                    Area   Area Identifier
                    ID     System Identifier
                    SEL    NSAP Selector

                  Figure 1: GOSIP Version 2 NSAP structure.


 */

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record NSAP
    /// </summary>
    [Serializable]
    public class RecordNsap : Record
    {
        public ushort Length;
        public byte[] Nsapaddress;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0} ", Length);
            foreach (var t in Nsapaddress)
                sb.AppendFormat("{0:X00}", t);
            return sb.ToString();
        }

        public string ToGosipv2()
        {
            return string.Format("{0:X}.{1:X}.{2:X}.{3:X}.{4:X}.{5:X}.{6:X}{7:X}.{8:X}",
                Nsapaddress[0], // AFI
                (Nsapaddress[1] << 8) | Nsapaddress[2], // IDI
                Nsapaddress[3], // DFI
                (Nsapaddress[4] << 16) | (Nsapaddress[5] << 8) | Nsapaddress[6], // AA
                (Nsapaddress[7] << 8) | Nsapaddress[8], // Rsvd
                (Nsapaddress[9] << 8) | Nsapaddress[10], // RD
                (Nsapaddress[11] << 8) | Nsapaddress[12], // Area
                (Nsapaddress[13] << 16) | (Nsapaddress[14] << 8) | Nsapaddress[15], // ID-High
                (Nsapaddress[16] << 16) | (Nsapaddress[17] << 8) | Nsapaddress[18], // ID-Low
                Nsapaddress[19]);
        }
    }
}