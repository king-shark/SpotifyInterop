using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyInterop.Models
{
    public class AlbumSimple
    {
        [JsonProperty("album_group")]
        public string AlbumGroup { get; set; }
        [JsonProperty("album_type")]
        public string AlbumType { get; set; }
        [JsonProperty("artists")]
        public List<ArtistSimple> Artists { get; set; }
        [JsonProperty("available_markets")]
        public List<string> AvailableMarket { get; set; }
        [JsonProperty("external_urls")]
        public JObject ExternalUrls { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("images")]
        public List<Image> Images { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
        [JsonProperty("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }
        [JsonProperty("restrictions")]
        public Restriction Restrictions { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonConstructor]
        public AlbumSimple()
        {

        }
    }
}
