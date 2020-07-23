using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class Restriction
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonConstructor]
        public Restriction()
        {

        }
    }
}
