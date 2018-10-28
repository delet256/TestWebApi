using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Examples;
using TestWebApi.Models;

namespace TestWebApi.Providers
{
    /// <summary>
    /// The default request
    /// </summary>
    public class RequestParametersDefault : IExamplesProvider
    {
        public object GetExamples()
        {
            return new RequestParameters
            {
                ApiToken = "Api Token",
                UserKey = "User Key",
                Message = "Message",
                Title = "",
                Sound = Sounds.Pushover
            };
        }
    }

}
