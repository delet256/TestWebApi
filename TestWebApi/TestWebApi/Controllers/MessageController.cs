using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.Models;

namespace WebApplication2.Controllers
{




    [Route("api/Message")]
    public class ValuesController : Controller
    {


        // POST api/values
        [HttpPost]
        public void Post([FromBody]RequestParameters item)
        {
            var parameters = new NameValueCollection {
                { "token", item.TokenApi },
                { "user", item.UserKey },
                { "message", item.Message }
            };

            using (var client = new WebClient())
            {
                client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
            }

        }


    }
}
