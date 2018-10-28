using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestWebApi.Models;

namespace TestWebApi
{
    /// <summary>
    /// Service for work with Pushover service
    /// </summary>
    public class PushoverService
    {
        private readonly string _apiToken;
        private readonly string _userKey;


        /// <summary>
        /// Initialize new instance of PushoverService
        /// </summary>
        /// <param name="apiToken">API token for pushover</param>
        /// <param name="userKey">User Key for pushover</param>
        public PushoverService(string apiToken, string userKey)
        {
            _apiToken = apiToken;
            _userKey = userKey;
        }
        /// <summary>
        /// Push message via pushover
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sound"></param>
        /// <param name="title"></param>
        public PushoverResponse Push(string message, string title, Sounds sound)
        {
            var parameters = new NameValueCollection {
                { "token", _apiToken },
                { "user", _userKey },
                { "message", message },
                { "title", title },
                { "sound", sound.ToString().ToLower() }
            };
            try
            {
                using (var client = new WebClient())
                {
                    var responseBytes = client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
                    var jsonString = Encoding.UTF8.GetString(responseBytes);
                    return JsonConvert.DeserializeObject<PushoverResponse>(jsonString);
                }
            }
            catch (System.Net.WebException ex)
            {

                var exceptionResponseBody = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                return JsonConvert.DeserializeObject<PushoverResponse>(exceptionResponseBody);
            }
        }
    }
}
