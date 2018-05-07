using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Netfluid.Dns.Internals
{
    /// <summary>
    ///     List of returned DNS record used by DNS server and resolver
    /// </summary>
    [Serializable]
    internal class Response : IEnumerable<Record>
    {
        /// <summary>
        ///     List of Record records
        /// </summary>
        public List<Record> Additionals;

        /// <summary>
        ///     List of Record records
        /// </summary>
        public List<Record> Answers;

        /// <summary>
        ///     List of Record records
        /// </summary>
        public List<Record> Authorities;

        /// <summary>
        ///     DNS response header
        /// </summary>
        internal Header Header;

        /// <summary>
        ///     The Size of the message
        /// </summary>
        internal int MessageSize;

        /// <summary>
        ///     List of Question records
        /// </summary>
        public List<Question> Questions;

        internal Response()
        {
            Questions = new List<Question>();
            Answers = new List<Record>();
            Authorities = new List<Record>();
            Additionals = new List<Record>();

            MessageSize = 0;
            Header = new Header {Flags = 33152};
        }


        /// <summary>
        ///     With same header of request
        /// </summary>
        /// <param name="request"></param>
        public Response(Request request)
        {
            Header = request.Header;
            Header.QR = true;
            Questions = new List<Question>(request);
            Answers = new List<Record>();
            Authorities = new List<Record>();
            Additionals = new List<Record>();

            MessageSize = 0;
        }

        public IEnumerator<Record> GetEnumerator() => Answers.Concat(Authorities.Concat(Additionals)).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Answers.Concat(Authorities.Concat(Additionals)).GetEnumerator();
    }
}