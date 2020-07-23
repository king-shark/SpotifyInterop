using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpotifyInterop.Models
{
    public class SpotifyCredentials
    {
        [JsonProperty("Username")]
        public string Username { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
        [JsonProperty("Client_Id")]
        public string ClientId { get; set; }
        [JsonProperty("Client_Secret")]
        public string ClientSecret { get; set; }

        public SpotifyCredentials()
        {

        }
        public SpotifyCredentials(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
        public SpotifyCredentials(string clientId, string clientSecret, string username, string password)
        {
            Username = username;
            Password = password;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
}
