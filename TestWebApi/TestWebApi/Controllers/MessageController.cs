using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    /// <summary>
    /// Controller
    /// </summary>
    [Route("api/message")]
    public class MessageController : Controller
    {
        /// <summary>
        /// Send message to pushover
        /// </summary>
        /// <param name="request">Data for send to pushover</param>
        [HttpPost]
        public void SendMessage([FromBody]RequestParameters request)
        {
            var pushoverService = new PushoverService(request.ApiToken,request.UserKey);
            pushoverService.Push(request.Message);
        }
    }
}
