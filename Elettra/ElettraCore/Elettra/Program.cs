using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using Netfluid;
using System;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Elettra
{
    public class Program
    {
        static NetfluidHost host;

        public static IMongoDatabase Database;
        public static GridFSBucket Grid;

        static System.IO.Stream Upload(string titolo, string contenuto,byte[] image)
        {
            var title = new StringContent(titolo);
            var content = new StringContent(contenuto);

            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(new StringContent("1"), "subject");
                formData.Add(title,"title");
                formData.Add(content, "content");
                formData.Add(new ByteArrayContent(image), "image");
                formData.Add(new StringContent("authenticated"), "authenticated");
                formData.Add(new StringContent("Insert"), "insert");

                var response = client.PostAsync("http://5cm.gennymobility.com/genny/pannello/index.php", formData).Result;
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                return response.Content.ReadAsStreamAsync().Result;
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region DATABASE
            var connectionString = ConfigurationManager.AppSettings["connectionString"];

            var client = connectionString == null ? new MongoClient() : new MongoClient(connectionString);
            Database = client.GetDatabase(ConfigurationManager.AppSettings["database"]);
            Grid = new GridFSBucket(Database);
            #endregion

            var hostName = ConfigurationManager.AppSettings["hostName"];

            host = new NetfluidHost($"http://{hostName}/");
            host.Map(typeof(Program).Assembly);

            host.PublicFolders.Add(new CDNFolder
            {
                RealPath = "./public",
                VirtualPath = "/public"
            });
            host.StartAsync();


            Application.Run(new frmMain());
        }
    }
}
