using System.Collections;
using System.Collections.Generic;

namespace Netfluid
{
    /// <summary>
    /// Return to the client a run time built CVS
    /// </summary>
    /// <typeparam name="T">The CSV is a collection of T typed objects</typeparam>
    public class CSVResponse<T> : IResponse
    {
        /// <summary>
        /// CSV text delimiter. Default value: '"'
        /// </summary>
        public char TextQualifier;

        /// <summary>
        /// CSV filed separator. Default value: ';'
        /// </summary>
        public char FieldSeparator;

        /// <summary>
        /// Collection on wich build the CSV
        /// </summary>
        public IEnumerable<T> Collection;

        public string FileName;

        /// <summary>
        /// Transform the collection into a CSV
        /// </summary>
        /// <param name="collection">to be serialized collection</param>
        public CSVResponse(IEnumerable<T> collection)
        {
            Collection = collection;
            FieldSeparator = ';';
            TextQualifier = '"';
        }

        /// <summary>
        /// Called by the Engine to set the CSV response headers.
        /// </summary>
        /// <param name="cnt">client context</param>
        public void SetHeaders(Context cnt)
        {
            if(!string.IsNullOrWhiteSpace(FileName))
                cnt.Response.Headers["Content-Disposition"] = "attachment; filename=\"" + FileName + "\"";

            cnt.Response.ContentType = "application/csv";
        }

        /// <summary>
        /// Send the CSV to the client
        /// </summary>
        /// <param name="cnt">client context</param>
        public void SendResponse(Context cnt)
        {
            CSV.Serialize(Collection, cnt.Writer, FieldSeparator, TextQualifier);
            cnt.Writer.Flush();
            cnt.Close();
        }

        public void Dispose()
        {
            
        }
    }
}
