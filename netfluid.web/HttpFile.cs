using System.IO;

namespace Netfluid
{
    public class HttpFile
    {
        public string Name;
        public string FileName;
        public string Extension;
        public string TempFile;

        public void SaveAs(string name, bool overwrite=true)
        {
            if (overwrite && File.Exists(name))
                File.Delete(name);

            File.Move(TempFile, name);
        }

        public string ContentDisposition { get; set; }

        public string ContentType { get; set; }

        public Stream Stream
        {
            get
            {
                return File.Open(TempFile,FileMode.Open);
            }
        }
    }
}
