using System;

namespace Netfluid.Dns
{
    [Serializable]
    public enum RecordClass : ushort
    {
        IN = 1, // the Internet
        CS = 2, // the CSNET class (Obsolete - used only for examples in some obsolete RFCs)
        CH = 3, // the CHAOS class
        HS = 4, // Hesiod [Dyer 87]

        //VALID ONLY INTO QUESTIONS
        ANY = 255 // any class
    }
}