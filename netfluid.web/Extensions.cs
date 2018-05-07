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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using Netfluid.HTTP;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using Netfluid.Json;
using System.ComponentModel;
using System.Net.Mail;

namespace Netfluid
{
    public static class Extensions
    {
        public static string[] GetKeywords(object obj)
        {
            return obj.GetType().GetProperties()
                .Where(x => x.PropertyType.Equals(typeof(string)))
                .Select(x => x.GetValue(obj) as string)
                .Where(x => x != null)
                .Select(x => x.ToLowerInvariant())
                .SelectMany(x => x.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                .Distinct()
                .ToArray();
        }

        public static T SanifyHTML<T>(this T obj)
        {
            var p = obj.GetType().GetProperties()
                .Where(x => x.PropertyType.Equals(typeof(string)) && x.CanWrite && x.CanRead).ToArray();

            p.ForEach(x=>
                {
                    try
                    {
                        var value = (x.GetValue(obj) ?? "") as string;
                        x.SetValue(obj, HTMLEncode(value));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                });

            obj.GetType().GetFields()
                .Where(x => x.FieldType.Equals(typeof(string)))
                .ForEach(x =>
                {
                    var value = (x.GetValue(obj) ?? "") as string;
                    x.SetValue(obj, Extensions.HTMLEncode(value));
                });
            return obj;
        }

        #region String

        /// <summary>
        /// Make first letter uppercase
        /// </summary>
        /// <param name="s">String to process</param>
        /// <returns>Passed string with first letter uppercase</returns>
        public static string FirstLetterUpperCase(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpperInvariant(a[0]);
            return new string(a);
        }

        #endregion

        /// <summary>
        /// Get root culture, i.e. the last parent before the invariant culture.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the root for.</param>
        /// <returns><paramref name="cultureInfo"/>'s root culture, i.e. the last parent before the invariant culture.</returns>
        public static CultureInfo GetRootCulture(this CultureInfo cultureInfo)
        {
            while (cultureInfo.Parent.LCID != CultureInfo.InvariantCulture.LCID)
                cultureInfo = cultureInfo.Parent;

            return cultureInfo;
        }
        


        #region LIST
        public static void Add<T>(this List<T> list, params T[] arr)
        {
            list.AddRange(arr);
        }

        #endregion

        #region APPDOMAIN

        /// <summary>
        /// Prevent exception if already loaded
        /// </summary>
        /// <param name="doamin">domain on wich load</param>
        /// <param name="file">file to load</param>
        /// <returns></returns>
        public static Assembly LoadAssembly(this AppDomain domain, string file)
        {
            var assemblies = domain.GetAssemblies();
            var path = Path.GetFullPath(file);
            var found = assemblies.Where(x=>!x.IsDynamic).FirstOrDefault(x => x.Location == path);

            if (found == null)
            {
                //windows service turn around...
                File.SetAttributes(path, FileAttributes.Normal);

                found = domain.Load(File.ReadAllBytes(path));
            }

            return found;
        }

        #endregion

        #region WINDOWS IDENTITY
        public static bool IsAdministrator(this WindowsIdentity user)
        {
            //bool value to hold our return value
            bool isAdmin;
            try
            {
                //get the currently logged in user
                var principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
        #endregion

        #region EXCEPTION

        public static string ToHTML(this Exception ex)
        {
            var sb = new StringBuilder("<h1>Exception " + ex.GetType().Name + "</h1>");
            sb.Append("<h2>" + ex.Message + "<h2>");
            sb.Append("<h2>StackTrace</h2>");
            sb.Append("<div>" + ex.StackTrace + "</div>");
            if (ex.InnerException != null)
            {
                sb.Append("<h2>Inner exception</h2>");
                sb.Append(ex.InnerException.ToHTML());
            }
            return sb.ToString();
        }

        #endregion

        #region IP ADDRESS

        private static readonly IPAddress _ipv4MulticastNetworkAddress = IPAddress.Parse("224.0.0.0");
        private static readonly IPAddress _ipv6MulticastNetworkAddress = IPAddress.Parse("FF00::");

        public static int ToInt32(this IPAddress ip)
        {
            var array = BitConverter.IsLittleEndian ? ip.GetAddressBytes().Reverse().ToArray() : ip.GetAddressBytes();
            return BitConverter.ToInt32(array,0);
        }

        /// <summary>
        ///     Reverses the order of the bytes of an IPAddress
        /// </summary>
        /// <param name="ipAddress"> Instance of the IPAddress, that should be reversed </param>
        /// <returns> New instance of IPAddress with reversed address </returns>
        public static IPAddress Reverse(this IPAddress ipAddress)
        {
            if (ipAddress == null)
                throw new ArgumentNullException("ipAddress");

            byte[] addressBytes = ipAddress.GetAddressBytes();
            var res = new byte[addressBytes.Length];

            for (int i = 0; i < res.Length; i++)
            {
                res[i] = addressBytes[addressBytes.Length - i - 1];
            }

            return new IPAddress(res);
        }

        /// <summary>
        ///     Gets the network address for a specified IPAddress and netmask
        /// </summary>
        /// <param name="ipAddress"> IPAddress, for that the network address should be returned </param>
        /// <param name="netmask"> Netmask, that should be used </param>
        /// <returns> New instance of IPAddress with the network address assigend </returns>
        public static IPAddress GetNetworkAddress(this IPAddress ipAddress, IPAddress netmask)
        {
            if (ipAddress == null)
                throw new ArgumentNullException("ipAddress");

            if (netmask == null)
                throw new ArgumentNullException("netMask");

            if (ipAddress.AddressFamily != netmask.AddressFamily)
                throw new ArgumentOutOfRangeException("netmask",
                    "Protocoll version of ipAddress and netmask do not match");

            byte[] resultBytes = ipAddress.GetAddressBytes();
            byte[] ipAddressBytes = ipAddress.GetAddressBytes();
            byte[] netmaskBytes = netmask.GetAddressBytes();

            for (int i = 0; i < netmaskBytes.Length; i++)
            {
                resultBytes[i] = (byte) (ipAddressBytes[i] & netmaskBytes[i]);
            }

            return new IPAddress(resultBytes);
        }

        /// <summary>
        ///     Gets the network address for a specified IPAddress and netmask
        /// </summary>
        /// <param name="ipAddress"> IPAddress, for that the network address should be returned </param>
        /// <param name="netmask"> Netmask in CIDR format </param>
        /// <returns> New instance of IPAddress with the network address assigend </returns>
        public static IPAddress GetNetworkAddress(this IPAddress ipAddress, int netmask)
        {
            if (ipAddress == null)
                throw new ArgumentNullException("ipAddress");

            if ((ipAddress.AddressFamily == AddressFamily.InterNetwork) && ((netmask < 0) || (netmask > 32)))
                throw new ArgumentException("Netmask have to be in range of 0 to 32 on IPv4 addresses", "netmask");

            if ((ipAddress.AddressFamily == AddressFamily.InterNetworkV6) && ((netmask < 0) || (netmask > 128)))
                throw new ArgumentException("Netmask have to be in range of 0 to 128 on IPv6 addresses", "netmask");

            byte[] ipAddressBytes = ipAddress.GetAddressBytes();

            for (int i = 0; i < ipAddressBytes.Length; i++)
            {
                if (netmask >= 8)
                {
                    netmask -= 8;
                }
                else
                {
                    if (BitConverter.IsLittleEndian)
                    {
                        ipAddressBytes[i] &= ReverseBitOrder((byte) ~(255 << netmask));
                    }
                    netmask = 0;
                }
            }

            return new IPAddress(ipAddressBytes);
        }

        /// <summary>
        ///     Returns the reverse lookup address of an IPAddress
        /// </summary>
        /// <param name="ipAddress"> Instance of the IPAddress, that should be used </param>
        /// <returns> A string with the reverse lookup address </returns>
        public static string GetReverseLookupAddress(this IPAddress ipAddress)
        {
            if (ipAddress == null)
                throw new ArgumentNullException("ipAddress");

            var res = new StringBuilder();

            byte[] addressBytes = ipAddress.GetAddressBytes();

            if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
            {
                for (int i = addressBytes.Length - 1; i >= 0; i--)
                {
                    res.Append(addressBytes[i]);
                    res.Append(".");
                }
                res.Append("in-addr.arpa");
            }
            else
            {
                for (int i = addressBytes.Length - 1; i >= 0; i--)
                {
                    string hex = addressBytes[i].ToString("x2");
                    res.Append(hex[1]);
                    res.Append(".");
                    res.Append(hex[0]);
                    res.Append(".");
                }

                res.Append("ip6.arpa");
            }

            return res.ToString();
        }

        /// <summary>
        /// True if this IP address belong to this machine
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        public static bool IsLocal(this IPAddress ipAddress)
        {
            return IPAddress.IsLoopback(ipAddress);
        }

        /// <summary>
        ///     Returns a value indicating whether a ip address is a multicast address
        /// </summary>
        /// <param name="ipAddress"> Instance of the IPAddress, that should be used </param>
        /// <returns> true, if the given address is a multicast address; otherwise, false </returns>
        public static bool IsMulticast(this IPAddress ipAddress)
        {
            if (ipAddress == null)
                throw new ArgumentNullException("ipAddress");

            if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
            {
                return ipAddress.GetNetworkAddress(4).Equals(_ipv4MulticastNetworkAddress);
            }
            return ipAddress.GetNetworkAddress(8).Equals(_ipv6MulticastNetworkAddress);
        }

        /// <summary>
        ///     Returns the index for the interface which has the ip address assigned
        /// </summary>
        /// <param name="ipAddress"> The ip address to look for </param>
        /// <returns> The index for the interface which has the ip address assigned </returns>
        public static int GetInterfaceIndex(this IPAddress ipAddress)
        {
            if (ipAddress == null)
                throw new ArgumentNullException("ipAddress");

            IPInterfaceProperties interfaceProperty =
                NetworkInterface.GetAllNetworkInterfaces()
                    .Select(n => n.GetIPProperties())
                    .FirstOrDefault(p => p.UnicastAddresses.Any(a => a.Address.Equals(ipAddress)));

            if (interfaceProperty != null)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPv4InterfaceProperties property = interfaceProperty.GetIPv4Properties();
                    if (property != null)
                        return property.Index;
                }
                else
                {
                    IPv6InterfaceProperties property = interfaceProperty.GetIPv6Properties();
                    if (property != null)
                        return property.Index;
                }
            }

            throw new ArgumentOutOfRangeException("ipAddress",
                "The given ip address is not configured on the local system");
        }

        private static byte ReverseBitOrder(byte value)
        {
            byte result = 0;

            for (int i = 0; i < 8; i++)
            {
                result |= (byte) ((((1 << i) & value) >> i) << (7 - i));
            }

            return result;
        }

        #endregion

        #region CONCURRENT BAG

        /// <summary>
        ///     Sintactic sugar for corr.TryTake(out elem);
        /// </summary>
        /// <param name="corr">Concurrent bag on wich remove the element</param>
        /// <param name="elem">Element to be removed</param>
        public static void Remove<T>(ConcurrentBag<T> corr, T elem)
        {
            corr.TryTake(out elem);
        }

        #endregion

        #region BYTE ARRAY

        public static string ToBase64(this byte[] array)
        {
            return Convert.ToBase64String(array);
        }

        #endregion

        #region STRING

        public static string DeCamel(this string str)
        {
            var arr = str.Where(x => char.IsUpper(x)).ToArray();

            foreach (var item in arr)
            {
                str = str.Replace(item.ToString(), " " + item);
            }
            return str.Trim();
        }

        public static IEnumerable<string> RegexValues(this string str, string regex)
        {
            var r = new Regex(regex);
            var res = new List<string>();

            foreach (Match item in r.Matches(str))
            {
                if (item.Success) res.Add(item.Value);
            }
            return res;
        }

        public static string GetDescription<T>(this T enumerationValue) where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            var memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();
        }

        public static string JsStyle(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;

            var arr = str.ToCharArray();
            arr[0] = char.ToLowerInvariant(arr[0]);

            for (int i = 0; i < arr.Length; i++)
                if (!char.IsLetterOrDigit(arr[i]))
                    arr[i] = '_';

            return new string(arr);
        }

        /// <summary>
        /// Trasnform a string into a stream
        /// </summary>
        /// <param name="str">string to convert</param>
        /// <returns>utf-8 encoded memory stream</returns>
        public static Stream ToStream(this string str)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        /// Encode to Base64 strings
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string ToBase64(this string str)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        /// Decode Base64 strings
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string FromBase64(this string str)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        public static string NormalizeSpace(this string str)
        {
            return System.Text.RegularExpressions.Regex.Replace(str.Trim(), @"\s+", " ");
        }

        public static string Urlify(this string str, bool timed=true)
        {
            if (str == null) return null;

            if (str == "") return "";

            var k = Extensions.StripHTML(str.Trim()).RemoveDiacritics();
            k = new string(k.Select(x =>
            {
                if (char.IsControl(x) || (char.IsPunctuation(x) && x!='.' ) || char.IsSeparator(x) || char.IsSymbol(x) || char.IsWhiteSpace(x))
                    return '-';
                return x;
            }).ToArray());

            while (k.Contains("--"))
            {
                k = k.Replace("--", "-");
            }

            if (k.Length > 64)
                k = k.Substring(0, 64);

            if (timed)
            {
                var date = DateTime.Now;
                return date.Year + "-"
                   + date.Month.ToString("00") + "-"
                   + date.Day.ToString("00") + "-"
                   + date.Hour.ToString("00") + "-"
                   + date.Minute.ToString("00") + "-"
                   + date.Second.ToString("00") + "-"
                   + date.Millisecond.ToString("000") + "-"
                   + Security.Random(9999) + "-" + k;
            }
            return k;
        }

        /// <summary>
        /// Replace inside a string using a regex
        /// </summary>
        /// <param name="str"></param>
        /// <param name="regex"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Replace(this string str, Regex regex, string value)
        {
            Match m;
            
            do
	        {
	            m = regex.Match(str);
                if (m.Success)
                    str = str.Replace(m.Value, value);
	        } while (m.Success);

            return str;
        }

        /// <summary>
        /// Convert a diatrics string into its base form ("crème brûlée" -> "creme brulee") 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string RemoveDiacritics(this string text)
        {
            if (string.IsNullOrEmpty(text)) return "";

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        ///     Check if is a valid credit card number
        /// </summary>
        /// <param name="cc">String to check</param>
        public static bool IsValidCreditCard(this string cc)
        {
            int[] deltas = {0, 1, 2, 3, 4, -4, -3, -2, -1, 0};
            int checksum = 0;
            char[] chars = cc.Where(char.IsDigit).ToArray();

            for (int i = chars.Length - 1; i > -1; i--)
            {
                int j = chars[i] - 48;
                checksum += j;
                if (((i - chars.Length)%2) == 0)
                    checksum += deltas[j];
            }

            return ((checksum%10) == 0);
        }

        public static string Capitalize(this string value)
        {
            if (value == null) return null;
            if (value == "") return "";

            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0])) array[0] = char.ToUpper(array[0]);
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ' && char.IsLower(array[i]))
                    array[i] = char.ToUpper(array[i]);
                else
                    array[i] = char.ToLowerInvariant(array[i]);
            }
            return new string(array);
        }

        /// <summary>
        ///     True if the string ends with given char
        /// </summary>
        /// <param name="str">String to checked</param>
        /// <param name="c">Char to be found</param>
        public static bool EndsWith(this string str, char c)
        {
            return str[str.Length - 1] == c;
        }


        /// <summary>
        ///     Replace invalid HTML chars with relative URL entities
        /// </summary>
        /// <param name="str">String to encoded</param>
        public static string URLEncode(this string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        ///     Replace HTML entities with relatives UTF-8 chars
        /// </summary>
        /// <param name="str">String to decoded</param>
        public static string URLDecode(this string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        public static string RemoveCamel(this string source)
        {
            for (int i = 1; i < source.Length; i++)
            {
                if (char.IsUpper(source[i]))
                {
                    source = source.Replace("" + source[i], " " + char.ToLower(source[i]));
                }
                else if (char.IsNumber(source[i]) && !char.IsNumber(source[i]))
                {
                    source = source.Replace("" + source[i], " " + char.ToLower(source[i]));
                }
            }
            return source;
        }

        /// <summary>
        ///     Replace invalid HTML chars with relative HTML entities
        /// </summary>
        /// <param name="str">String to encoded</param>
        public static string HTMLEncode(this string str)
        {
            return HttpUtility.HtmlEncode(str);
        }

        /// <summary>
        ///     Replace HTML entities with relatives UTF-8 chars
        /// </summary>
        /// <param name="str">String to decoded</param>
        public static string HTMLDecode(this string str)
        {
            return HttpUtility.HtmlDecode(str);
        }

        public static string DynamicSubstring(this string source, int maxLength)
        {
            return source.Length >= maxLength ? source.Substring(0, maxLength) : source;
        }

        /// <summary>
        ///     Remove all HTML tags
        /// </summary>
        /// <param name="str">String to be cleaned</param>
        public static string StripHTML(this string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            var array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;
            bool spacebefore = false;

            foreach (char @let in source)
            {
                if (@let == '<')
                {
                    inside = true;
                    continue;
                }
                if (@let == '>')
                {
                    inside = false;
                    continue;
                }
                if (inside)
                    continue;

                if (char.IsWhiteSpace(@let))
                {
                    if (!spacebefore && arrayIndex != 0 && !char.IsWhiteSpace(array[arrayIndex]))
                    {
                        array[arrayIndex] = ' ';
                        arrayIndex++;
                    }
                    spacebefore = true;
                }
                else
                {
                    array[arrayIndex] = @let;
                    arrayIndex++;
                    spacebefore = false;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        #endregion

        #region STRING ENUMERABLE
        public static string Join(this IEnumerable<string> enu,string separator)
        {
            return string.Join(separator, enu);
        }
        #endregion

        #region ENUMERABLE

        public static void Split<T>(this IEnumerable<T> source, Func<T, bool> select,Action<T> where, Action<T> notWhere)
        {
            foreach (var item in source)
            {
                if (select(item))
                    where(item);
                else
                    notWhere(item);
            }
        }

        public static IEnumerable<T>[] Split<T>(this IEnumerable<T> source,Func<T,bool> select)
        {
            var i0 = new List<T>();
            var i1 = new List<T>();

            foreach (var item in source)
            {
                if (select(item))
                    i0.Add(item);
                else
                    i1.Add(item);
            }
            return new IEnumerable<T>[] { i0,i1 };
        }

        /// <summary>
        /// Return a random collection of elements
        /// </summary>
        /// <param name="source">The collection</param>
        public static IEnumerable<T> Random<T>(this IEnumerable<T> source, int len)
        {
            for (int i = 0; i < len; i++)
            {
                yield return Random(source);
            }
        }

        /// <summary>
        ///     Return a random element from the collection
        /// </summary>
        /// <param name="source">The collection</param>
        public static T Random<T>(this IEnumerable<T> source)
        {
            int c = source.Count();
            return source.Skip(Security.Random(c - 1)).First();
        }

        /// <summary>
        ///     Split the collection in batch of N elements
        /// </summary>
        /// <param name="source">Collection to be splitted</param>
        /// <param name="batchSize">Length of the batch</param>
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int batchSize)
        {
            using (IEnumerator<T> enumerator = source.GetEnumerator())
                while (enumerator.MoveNext())
                    yield return YieldBatchElements(enumerator, batchSize - 1);
        }

        private static IEnumerable<T> YieldBatchElements<T>(IEnumerator<T> source, int batchSize)
        {
            yield return source.Current;
            for (int i = 0; i < batchSize && source.MoveNext(); i++)
                yield return source.Current;
        }

        /// <summary>
        ///     Apply an action on any elements in the collections
        /// </summary>
        /// <param name="enu">The collection</param>
        /// <param name="batchSize">The action</param>
        public static void ForEach<T>(this IEnumerable<T> enu, Action<T> act)
        {
            if (enu == null) return;

            foreach (var obj in enu)
            {
                act.Invoke(obj);
            }
        }

        /// <summary>
        ///     Sintactic sugar for (new[]{elem}).Concat(enu)
        /// </summary>
        public static IEnumerable<T> Concat<T>(this T elem, IEnumerable<T> enu)
        {
            return (new[] { elem }).Concat(enu);
        }

        /// <summary>
        ///     Sintactic sugar for enu.Concat(new[]{elem})
        /// </summary>
        public static IEnumerable<T> Concat<T>(this IEnumerable<T> enu, T elem)
        {
            return enu.Concat(new[] {elem});
        }

        #endregion

        public static void Map<Y,T>(this  Y obj, T input)
        {
            var propsT = typeof(T).GetProperties();
            var propsY = typeof(Y).GetProperties();

            var similarsT = propsT.Where(x =>
                          propsY.Any(y => y.Name == x.Name
                   && y.PropertyType == x.PropertyType)).OrderBy(x => x.Name).ToList();

            var similarsY = propsY.Where(x =>
                            propsT.Any(y => y.Name == x.Name
                    && y.PropertyType == x.PropertyType)).OrderBy(x => x.Name).ToList();

            for (int i = 0; i < similarsY.Count; i++)
            {
                similarsY[i]
                .SetValue(obj, similarsT[i].GetValue(input, null), null);
            }
        }

        #region ARRAY

        /// <summary>
        ///     Sintactic sugar for enu.Concat(new[] { elem }).ToArray()
        /// </summary>
        public static T[] Push<T>(this T[] enu, T elem)
        {
            return enu.Concat(new[] {elem}).ToArray();
        }

        #endregion

        #region DATETIME

        /// <summary>
        /// GMT ( http headers ) conversion of datetime
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToGMT(this DateTime date)
        {
            return date.ToUniversalTime().ToString("r", CultureInfo.InvariantCulture);
        }

        /// <summary>
        ///     Convert datetime in number of seconds from 00:00:00 1/1/1970
        /// </summary>
        public static double ToUnixTimestamp(this DateTime date)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Math.Round((date - epoch).TotalSeconds);
        }

        #endregion

        #region SERIALIZATION

        public static void ToBinary(this object obj, Stream stream)
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
        }

        public static byte[] ToBinary(this object obj)
        {
            var formatter = new BinaryFormatter();
            var s = new MemoryStream();
            formatter.Serialize(s, obj);
            return s.ToArray();
        }

        public static string ToJSON(this object obj)
        {
            return JSON.Serialize(obj);
        }

        #endregion

        #region METHODINFO

        /// <summary>
        /// True if the method is overriden
        /// </summary>
        /// <param name="methodInfo"></param>
        /// <returns></returns>
        public static bool IsOverride(this MethodInfo methodInfo)
        {
            return (methodInfo.GetBaseDefinition() != methodInfo);
        }

        /// <summary>
        /// Builds a Delegate instance from the supplied MethodInfo object and a target to invoke against.
        /// </summary>
        public static Delegate ToDelegate(this MethodInfo mi, object target)
        {
            Type delegateType;

            var typeArgs = mi.GetParameters()
                .Select(p => p.ParameterType)
                .ToList();

            // builds a delegate type
            if (mi.ReturnType == typeof(void))
            {
                delegateType = Expression.GetActionType(typeArgs.ToArray());

            }
            else
            {
                typeArgs.Add(mi.ReturnType);
                delegateType = Expression.GetFuncType(typeArgs.ToArray());
            }

            // creates a binded delegate if target is supplied
            var result = (target == null)
                ? Delegate.CreateDelegate(delegateType, mi)
                : Delegate.CreateDelegate(delegateType, target, mi);

            return result;
        }

        /// <summary>
        ///     Return True if this method has an attribute of type T
        /// </summary>
        public static bool HasAttribute<T>(this MethodInfo type) where T : Attribute
        {
            bool b = type.GetCustomAttributes(false).OfType<T>().Any();
            return b;
        }

        /// <summary>
        ///     Return all attributes of type T of this method
        /// </summary>
        public static T[] CustomAttribute<T>(this MethodInfo type) where T : Attribute
        {
            return type.GetCustomAttributes(false).Where(x => x.GetType() == typeof(T)).Cast<T>().ToArray();
        }

        #endregion

        #region FIELD INFO

        /// <summary>
        ///     Return True if this field has an attribute of type T
        /// </summary>
        public static bool HasAttribute<T>(this FieldInfo type) where T : Attribute
        {
            bool b = type.GetCustomAttributes(false).OfType<T>().Any();
            return b;
        }

        /// <summary>
        ///     Return all attributes of type T of this field
        /// </summary>
        public static T[] CustomAttribute<T>(this FieldInfo type) where T : Attribute
        {
            return type.GetCustomAttributes(true).OfType<T>().ToArray();
        }

        #endregion

        #region PROPERTYINFO

        /// <summary>
        ///     Retrieve the value of this property for object obj
        /// </summary>
        public static object GetValue(this PropertyInfo pi, object obj)
        {
            return pi.GetGetMethod(true).Invoke(obj, null);
        }

        /// <summary>
        ///     Return True if this property has an attribute of type T
        /// </summary>
        public static bool HasAttribute<T>(this PropertyInfo type) where T : Attribute
        {
            bool b = type.GetCustomAttributes(false).OfType<T>().Any();
            return b;
        }

        /// <summary>
        ///     Return all attributes of type T of this property
        /// </summary>
        public static T[] CustomAttribute<T>(this PropertyInfo type) where T : Attribute
        {
            return type.GetCustomAttributes(true).OfType<T>().ToArray();
        }

        #endregion

        #region PARAMETERINFO

        public static object MissingValue(this ParameterInfo info)
        {
            if (info.IsOptional)
                return Type.Missing;

            return   info.ParameterType.IsValueType ? Activator.CreateInstance(info.ParameterType): null;
        }

        #endregion

        #region TYPE

        public static bool HasDefaultConstructor(this Type type)
        {
            return type.GetConstructor(Type.EmptyTypes) != null;
        }

        /// <summary>
        ///     Return all fields
        /// </summary>
        public static FieldInfo[] GetAllFields(this Type type)
        {
            return type.GetFields();
        }


        /// <summary>
        ///     Return the default value of the type
        /// </summary>
        public static object DefaultValue(this Type type)
        {
            return type.IsValueType ? Activator.CreateInstance(type) : null;
        }

        /// <summary>
        ///     True if this method define an attribute of type T
        /// </summary>
        public static bool HasAttribute<T>(this Type type, bool inherit) where T : Attribute
        {
            object[] b = type.GetCustomAttributes(inherit);
            IEnumerable<T> c = b.OfType<T>();
            return c.Any();
        }

        /// <summary>
        ///     Return all attributes of type T of this type
        /// </summary>
        public static T[] CustomAttribute<T>(this Type type, bool inherit) where T : Attribute
        {
            return type.GetCustomAttributes(inherit).OfType<T>().ToArray();
        }

        /// <summary>
        ///     Return all inherited types
        /// </summary>
        public static Type[] Ancestor(this Type me)
        {
            Type t = me;
            var result = new List<Type>();
            while (t != typeof (object) && t != null)
            {
                if (t != typeof (object))
                {
                    result.Add(t);
                }
                t = t.BaseType;
            }
            return result.ToArray();
        }

        /// <summary>
        ///     True if the type inherit the given one
        ///     Runtime equivalent of "is" operator
        /// </summary>
        /// <param name="type">Anchestor to be checked</param>
        public static bool Inherit(this Type me, Type type)
        {
            Type t = me;

            while (t != typeof (object) && t != null)
            {
                if (t == type)
                {
                    return true;
                }
                t = t.BaseType;
            }
            return false;
        }

        /// <summary>
        ///     True if the type implements the given interface
        /// </summary>
        public static bool Implements(this Type type, Type @interface)
        {
            if (type == @interface)
                return true;

            Type[] ints = type.GetInterfaces();
            return ints.Any(x => x == @interface || (x.IsGenericType && x.GetGenericTypeDefinition() == @interface));
        }

        /// <summary>
        ///     Create an instance of the type
        /// </summary>
        /// <param name="obj">Consructor parameters.None to use default constructor</param>
        public static object CreateIstance(this Type type, params object[] obj)
        {
            return (obj == null || obj.Length == 0)
                ? Activator.CreateInstance(type)
                : Activator.CreateInstance(type, obj);
        }

        #endregion

        #region STREAM

        /// <summary>
        ///     Read all bytes into the stream
        /// </summary>
        public static string ToBase64(this Stream s)
        {
            var ms = new MemoryStream();
            s.CopyTo(ms);
            return ms.ToArray().ToBase64();
        }

        /// <summary>
        ///     Read all bytes into the stream
        /// </summary>
        public static byte[] BinaryRead(this Stream s)
        {
            var b = new byte[s.Length - s.Position];
            s.Read(b, 0, b.Length);
            return b;
        }

        #endregion
    }
}