using Dropbox.Api;
using Dropbox.Api.Files;

namespace OnlineRestaurantMenu.DropBox
{
    public class DropBoxUploadFile
    {
        private static string token = "zGZbzYCEyxUAAAAAAAAAAVqRtilMPcqaCKZhWwTgAXHWyvJnVADja0bhVqYNPsq1";
        public static async Task Upload(string path,string fileName)
        {
            using (var dbx = new DropboxClient(token))
            {
                string file = path;
                string filename = fileName;
                string url = "";
                using (var mem = new MemoryStream(File.ReadAllBytes(file)))
                {
                    var updated = dbx.Files.UploadAsync("/" + filename, WriteMode.Overwrite.Instance, body: mem);
                    updated.Wait();
                    var tx = dbx.Sharing.CreateSharedLinkWithSettingsAsync("/" + filename);
                    tx.Wait();
                    url = tx.Result.Url;
                }
            }
        }
     
        public static async Task Download(string fileName)
        {
            using (var dbx = new DropboxClient(token))
            {
                using (var response = await dbx.Files.DownloadAsync("/" + fileName))
                {
                    var s = response.GetContentAsByteArrayAsync();
                    s.Wait();
                    var d = s.Result;
                    File.WriteAllBytes(fileName, d);
                }
            }
          
        }
    }
}
