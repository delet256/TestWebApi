using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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
        public void Push(string message)
        {
            var parameters = new NameValueCollection {
                { "token", _apiToken },
                { "user", _userKey },
                { "message", message }
            };

            using (var client = new WebClient())
            {
                client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
            }
        }
    }
}
