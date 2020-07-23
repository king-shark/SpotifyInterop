using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class Followers
    {
        [JsonProperty("href")]
        public string Href { get; set; }
        [JsonProperty("total")]
        public string Total { get; set; }
        [JsonConstructor]
        public Followers()
        {

        }
    }
}
