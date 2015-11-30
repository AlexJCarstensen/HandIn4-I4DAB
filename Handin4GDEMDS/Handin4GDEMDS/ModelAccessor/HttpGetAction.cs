using System;
using System.IO;
using System.Net;
using System.Text;

namespace Handin4GDEMDS.ModelAccessor
{
    public class HttpGetAction
    {
        /// <summary>
        /// Checks for internet connection
        /// </summary>
        /// <returns>
        /// true : connection to internet success
        /// false : connection to internet failed
        /// </returns>
        public static bool IsInternetConnectionEnabled()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    using (var stream = webClient.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Make a get request to url
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        /// returns responce as string
        /// </returns>
        public static string Get(string url)
        {
            var request = WebRequest.Create(url);
            try
            {
                using (var response = request?.GetResponse() as HttpWebResponse)
                {
                    if (response?.StatusCode != HttpStatusCode.OK)
                        throw new Exception($"Server error (HTTP {response?.StatusCode}: {response?.StatusDescription}).");
                    using (var stream = response?.GetResponseStream())
                    {
                        if (stream == null) return string.Empty;
                        var reader = new StreamReader(stream, Encoding.UTF8);
                        return reader.ReadToEnd();
                    }

                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}