// ********************************************************************************************************
// <copyright company="NetFluid">
//     Copyright (c) 2013 Matteo Fabbri. All rights reserved.
// </copyright>
// ********************************************************************************************************
// The contents of this file are subject to the GNU AGPL v3.0 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http://www.fsf.org/licensing/licenses/agpl-3.0.html 
// 
// Commercial licenses are also available from http://netfluid.org/, including free evaluation licenses.
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specific language governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this file is Matteo Fabbri.
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date           Changed By      Notes
// 23/10/2013    Matteo Fabbri      Inital coding
// ********************************************************************************************************

using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Netfluid
{
    /// <summary>
    /// Utilities for security
    /// </summary>
    public static class Security
    {
        private static Random RandomGenerator;

        static Security()
        {
            RandomGenerator = new Random();
        }

        /// <summary>
        /// Return an empty temp file (System.IO.Path.GetTempFileName sometimes return the same value on two calling
        /// </summary>
        public static string TempFile
        {
            get
            {
                //Path.GetTempFileName() SOMETIMES RETURN THE SAME FILENAME ON TWO CALLINGS
                string p;
                do p = Path.Combine(Path.GetTempPath(), UID()); while (File.Exists(p));
                return Path.GetFullPath(p);
            }
        }

        /// <summary>
        /// Transform a string into a System.Security.SecureString
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static SecureString Secure(string original)
        {
            var secure = new SecureString();
            original.ForEach(secure.AppendChar);
            return secure;
        }

        public static void GenerateRSAKeys(out string publicKey, out string privateKey, int bytes=2048)
        {
            var csp = new RSACryptoServiceProvider(bytes);
            publicKey = csp.ToXmlString(false);
            privateKey = csp.ToXmlString(true);
        }

        public static string RSACrypt(string publicKey,string source)
        {
            var csp = new RSACryptoServiceProvider();
            csp.FromXmlString(publicKey);
            return Base64Encode(csp.Encrypt(Encoding.UTF8.GetBytes(source),false));
        }

        public static string RSADecrypt(string privateKey, string source)
        {
            var csp = new RSACryptoServiceProvider();
            csp.FromXmlString(privateKey);
            return Encoding.UTF8.GetString(csp.Decrypt(Base64Decode(source),false));
        }

        /// <summary>
        /// From base64 to byte
        /// </summary>
        /// <param name="str">base 64</param>
        /// <returns>decoded bytes</returns>
        public static byte[] Base64Decode(string str)
        {
            str = str == null ? "" : str;
            return Convert.FromBase64String(str);
        }

        /// <summary>
        /// From bytes to base64
        /// </summary>
        /// <param name="toEncode">bytes to encode</param>
        /// <returns></returns>
        public static string Base64Encode(byte[] toEncode)
        {
            toEncode = toEncode == null ? new byte[0] : toEncode;
            return Convert.ToBase64String(toEncode);
        }

        public static string SystemFingerPrint
        {
            get
            {
               var k = Environment.GetLogicalDrives().Join("") +
                       Environment.Is64BitOperatingSystem +
                       Environment.MachineName +
                       Environment.OSVersion.ToString() +
                       Environment.ProcessorCount +
                       Environment.SystemDirectory +
                       Environment.SystemPageSize +
                       Environment.UserDomainName +
                       Environment.UserName;

               return SHA512(k);
            }
        }



        /// <summary>
        /// SHA512 hashing of string
        /// </summary>
        /// <param name="text">string to hash</param>
        /// <returns>base64 hash</returns>
        public static string SHA512(string str)
        {
            str = str == null ? "" : str;

            var s = new SHA512Managed();
            return Base64Encode(s.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        /// <summary>
        /// SHA512 hashing of stream
        /// </summary>
        /// <param name="stream">stream to hash</param>
        /// <returns>base64 hash</returns>
        public static string SHA512(Stream stream)
        {
            var s = new SHA512Managed();
            return Base64Encode(s.ComputeHash(stream));
        }


        /// <summary>
        /// SHA1 hashing of string
        /// </summary>
        /// <param name="text">string to hash</param>
        /// <returns>base64 hash</returns>
        public static string SHA1(string str)
        {
            str = str == null ? "" : str;

            var s = new SHA1Managed();
            return Base64Encode(s.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        /// <summary>
        /// SHA384 hashing of string
        /// </summary>
        /// <param name="text">string to hash</param>
        /// <returns>base64 hash</returns>
        public static string SHA384(string str)
        {
            str = str == null ? "" : str;

            var s = new SHA384Managed();
            return Base64Encode(s.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        /// <summary>
        /// SHA256 hashing of string
        /// </summary>
        /// <param name="text">string to hash</param>
        /// <returns>base64 hash</returns>
        public static string SHA256(string str)
        {
            str = str == null ? "" : str;

            var s = new SHA256Managed();
            return Base64Encode(s.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }


        /// <summary>
        ///     Return a random value (avoid System.Random repetition)
        /// </summary>
        /// <returns></returns>
        public static int Random()
        {
            return RandomGenerator.Next();
        }

        /// <summary>
        ///     Return a random value from to 0 to max (avoid System.Random repetition)
        /// </summary>
        /// <param name="max">maximum value</param>
        /// <returns></returns>
        public static int Random(int max)
        {
            return RandomGenerator.Next(max);
        }

        /// <summary>
        ///     Return a random value from to min to max (avoid System.Random repetition)
        /// </summary>
        /// <param name="min">minimun value</param>
        /// <param name="max">maximum value</param>
        /// <returns></returns>
        public static int Random(int min, int max)
        {
            return RandomGenerator.Next(min, max);
        }

        public static string UID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}