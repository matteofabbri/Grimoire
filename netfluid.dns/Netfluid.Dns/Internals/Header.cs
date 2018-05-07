using System;

namespace Netfluid.Dns.Internals
{
    /// <summary>
    ///     DNS Request and Response header
    /// </summary>
    [Serializable]
    internal struct Header
    {
        /// <summary>
        ///     the number of resource records in the answer section
        /// </summary>
        public ushort ANCOUNT;

        /// <summary>
        ///     the number of resource records in the additional records section
        /// </summary>
        public ushort ARCOUNT;

        public ushort Flags;

        /// <summary>
        ///     An identifier assigned by the program
        /// </summary>
        public ushort ID;

        /// <summary>
        ///     the number of name server resource records in the authority records section
        /// </summary>
        public ushort NSCOUNT;

        /// <summary>
        ///     the number of entries in the question section
        /// </summary>
        public ushort QDCOUNT;

        /// <summary>
        ///     query (false), or a response (true)
        /// </summary>
        public bool QR
        {
            get => GetBits(Flags, 15, 1) == 1;
            set => Flags = SetBits(Flags, 15, 1, value);
        }

        /// <summary>
        ///     Specifies kind of query
        /// </summary>
        public OpCode OPCODE
        {
            get => (OpCode) GetBits(Flags, 11, 4);
            set => Flags = SetBits(Flags, 11, 4, (ushort) value);
        }

        /// <summary>
        ///     Authoritative Answer
        /// </summary>
        public bool AA
        {
            get => GetBits(Flags, 10, 1) == 1;
            set => Flags = SetBits(Flags, 10, 1, value);
        }

        /// <summary>
        ///     TrunCation
        /// </summary>
        public bool TC
        {
            get => GetBits(Flags, 9, 1) == 1;
            set => Flags = SetBits(Flags, 9, 1, value);
        }

        /// <summary>
        ///     Recursion Desired
        /// </summary>
        public bool RD
        {
            get => GetBits(Flags, 8, 1) == 1;
            set => Flags = SetBits(Flags, 8, 1, value);
        }

        /// <summary>
        ///     Recursion Available
        /// </summary>
        public bool RA
        {
            get => GetBits(Flags, 7, 1) == 1;
            set => Flags = SetBits(Flags, 7, 1, value);
        }

        /// <summary>
        ///     Reserved for future use
        /// </summary>
        public ushort Z
        {
            get => GetBits(Flags, 4, 3);
            set => Flags = SetBits(Flags, 4, 3, value);
        }

        /// <summary>
        ///     Response code
        /// </summary>
        public ResponseCode RCode
        {
            get => (ResponseCode) GetBits(Flags, 0, 4);
            set => Flags = SetBits(Flags, 0, 4, (ushort) value);
        }

        private static ushort SetBits(ushort oldValue, int position, int length, bool blnValue)
        {
            return SetBits(oldValue, position, length, blnValue ? (ushort) 1 : (ushort) 0);
        }

        private static ushort SetBits(ushort oldValue, int position, int length, ushort newValue)
        {
            // sanity check
            if (length <= 0 || position >= 16)
                return oldValue;

            // get some mask to put on
            var mask = (2 << (length - 1)) - 1;

            // clear out value
            oldValue &= (ushort) ~(mask << position);

            // set new value
            oldValue |= (ushort) ((newValue & mask) << position);
            return oldValue;
        }

        private static ushort GetBits(ushort oldValue, int position, int length)
        {
            // sanity check
            if (length <= 0 || position >= 16)
                return 0;

            // get some mask to put on
            var mask = (2 << (length - 1)) - 1;

            // shift down to get some value and mask it
            return (ushort) ((oldValue >> position) & mask);
        }
    }
}