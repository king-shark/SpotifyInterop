using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class Image
    {
        [JsonProperty("height")]
        public string Height { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("width")]
        public string Width { get; set; }
        [JsonConstructor]
        public Image()
        {

        }

    }
}
