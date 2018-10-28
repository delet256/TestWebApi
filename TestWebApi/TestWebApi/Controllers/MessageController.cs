using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Examples;
using TestWebApi.Models;
using TestWebApi.Providers;

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
        [SwaggerRequestExample(typeof(RequestParameters), typeof(RequestParametersDefault))]
        public IActionResult SendMessage([FromBody]RequestParameters request)
        {
            var pushoverService = new PushoverService(request.ApiToken, request.UserKey);
            var response = pushoverService.Push(request.Message, request.Title, request.Sound);
            if (response.Status == 0)
                return BadRequest(String.Join("\n", response.Errors));
            else
                return Ok("Success");
        }
    }
}