using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class TrackSimple
    {
        [JsonProperty("artists")]
        public string Artists { get; set; }
        [JsonProperty("available_markets")]
        public string AvailableMarkets { get; set; }
        [JsonProperty("disc_number")]
        public string DiscNumber { get; set; }
        [JsonProperty("duration_ms")]
        public string DurationMs { get; set; }
        [JsonProperty("explicit")]
        public string Explicit { get; set; }
        [JsonProperty("external_urls")]
        public string ExternalUrls { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("is_playable")]
        public string IsPlayable { get; set; }
        [JsonProperty("linked_from")]
        public string LinkedFrom { get; set; }
        [JsonProperty("restrictions")]
        public string Restrictions { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }
        [JsonProperty("track_number")]
        public string TrackNumber { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonProperty("is_local")]
        public string IsLocal { get; set; }
        [JsonConstructor]
        public TrackSimple()
        {

        }
    }
}
