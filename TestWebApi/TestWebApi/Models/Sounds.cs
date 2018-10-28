using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestWebApi.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Sounds
    {
        /// <summary>
        /// Collection of sounds for RequestParameters
        /// </summary>
        Pushover,
        Bike,
        Bugle,
        Cashregister,
        Classical,
        Cosmic,
        Falling,
        Gamelan,
        Incoming,
        Intermission,
        Magic,
        Mechanical,
        Pianobar,
        Siren,
        Spacealarm,
        Tugboat,
        Alien,
        Climb,
        Persistent,
        Echo,
        Updown,
        None
    }
}
