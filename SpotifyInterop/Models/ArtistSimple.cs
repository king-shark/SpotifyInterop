using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class ArtistSimple
    {
        [JsonProperty("external_urls")]
        public JObject ExternalUrls { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonConstructor]
        public ArtistSimple()
        {

        }
    }
}
