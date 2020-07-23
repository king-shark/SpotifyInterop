﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class ArtistFull
    {
        [JsonProperty("external_urls")]
        public JObject ExternalUrls { get; set; }
        [JsonProperty("followers")]
        public Followers Followers { get; set; }
        [JsonProperty("genres")]
        public List<string> Genres { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("images")]
        public List<Image> Images { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("popularity")]
        public int Popularity { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonConstructor]
        public ArtistFull()
        {
        }
    }
}
