using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi.Models
{
    /// <summary>
    /// Model for response
    /// </summary>
    public class PushoverResponse
    {
        /// <summary>
        /// Gets ot sets Status
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Gets or sets Errors
        /// </summary>
        public string[] Errors { get; set; }
    }
}
