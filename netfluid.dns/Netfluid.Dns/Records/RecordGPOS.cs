/* 
 * http://tools.ietf.org/rfc/rfc1712.txt
 * 
3. RDATA Format

        MSB                                        LSB
        +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
        /                 LONGITUDE                  /
        +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
        /                  LATITUDE                  /
        +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
        /                  ALTITUDE                  /
        +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

   where:

   LONGITUDE The real number describing the longitude encoded as a
             printable string. The precision is limited by 256 charcters
             within the range -90..90 degrees. Positive numbers
             indicate locations north of the equator.

   LATITUDE The real number describing the latitude encoded as a
            printable string. The precision is limited by 256 charcters
            within the range -180..180 degrees. Positive numbers
            indicate locations east of the prime meridian.

   ALTITUDE The real number describing the altitude (in meters) from
            mean sea-level encoded as a printable string. The precision
            is limited by 256 charcters. Positive numbers indicate
            locations above mean sea-level.

   Latitude/Longitude/Altitude values are encoded as strings as to avoid
   the precision limitations imposed by encoding as unsigned integers.
   Although this might not be considered optimal, it allows for a very
   high degree of precision with an acceptable average encoded record
   length.

 */

using System;

namespace Netfluid.Dns.Records
{
    /// <summary>
    ///     DNS record GPOS
    /// </summary>
    [Serializable]
    public class RecordGpos : Record
    {
        public string Altitude;
        public string Latitude;
        public string Longitude;

        public override string ToString()
        {
            return $"{Longitude} {Latitude} {Altitude}";
        }
    }
}