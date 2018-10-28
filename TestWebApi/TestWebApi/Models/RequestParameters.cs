using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TestWebApi.Models
{
    /// <summary>
    /// Model for request 
    /// </summary>
    public class RequestParameters
    {
        /// <summary>
        /// Gets or sets Api Token
        /// </summary>
        public string ApiToken { get; set; }
        /// <summary>
        /// Gets or sets User Key
        /// </summary>
        public string UserKey { get; set; }
        /// <summary>
        /// Gets or sets Message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Gets or sets Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Get or sets Sound
        /// </summary>
        public Sounds Sound { get; set; }
    }
}
