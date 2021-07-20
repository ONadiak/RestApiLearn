using System.IO;
using System.Net;

namespace APILearn.FrameWork
{
    public class APIRequest
    {
        public static string SentRequest(string url)
        {
            string response;
            HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();
            
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            return response;
        }
    }
}