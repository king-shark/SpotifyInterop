using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class Copyright
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonConstructor]
        public Copyright()
        {

        }
    }
}
