using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpotifyInterop.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.Security.Policy;

namespace SpotifyInterop
{
    public class SpotifyClient
    {
        
        public bool IsExpired { get => CreatedAt.AddSeconds(ExpiresIn) <= DateTime.UtcNow; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        private SpotifyCredentials _credentials = null;
        private string _authUrl = "https://accounts.spotify.com/api/token";
        private string _baseUrl = "https://api.spotify.com/v1/";
        private string _artists = "artists/";

        private static HttpClient _httpClient = new HttpClient(new HttpClientHandler { UseProxy = false });
        public string AccessToken = null;
        public string TokenType = null;
        public int ExpiresIn = 0;
        public string RefreshToken = null;
        public string Market = "US";
                
        public SpotifyClient(SpotifyCredentials credentials)
        {
            _credentials = credentials;
            GetAuthToken();
        }

        private void GetAuthToken()
        //Client Credentials Auth Flow
        {
            _authUrl = "https://accounts.spotify.com/api/token";
            FormUrlEncodedContent formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
            });

            _httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + Base64Encode(_credentials.ClientId + ":" + _credentials.ClientSecret));

            HttpResponseMessage httpResponseMessage = _httpClient.PostAsync(_authUrl, formContent).Result;
            string response = httpResponseMessage.Content.ReadAsStringAsync().Result;

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                TokenType = jObject["token_type"].Value<string>();
                AccessToken = jObject["access_token"].Value<string>();
                ExpiresIn = jObject["expires_in"].Value<int>();
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", TokenType + " " + AccessToken);
            }
            else
            {
                throw new Exception($"Error getting access token: { response }.");
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public void Search()
        {


        }

        private JObject ArtistRequest(string uri)
        {
            HttpResponseMessage httpResponseMessage = _httpClient.GetAsync(uri).Result;
            string response = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
                return jObject;
            }
            else
            {
                throw new Exception($"Error getting artist info: { response }.");
            }
        }
        public ArtistFull GetArtist(string id)
        {
            string uri = _baseUrl + _artists + id;            
            return ArtistRequest(uri).ToObject<ArtistFull>();
        }
        public List<ArtistFull> GetArtists(List<string> ids)
        {
            if (ids.Count > 50)
            {
                throw new Exception("Max 50 Artist IDs allowed");
            }
            else
            {
                string uri = _baseUrl + _artists + String.Join(",", ids);
                return ArtistRequest(uri)["artists"].ToObject<List<ArtistFull>>();
            }            
        }
        public PagingObject<AlbumSimple> GetArtistAlbums(string id)
        {
            string uri = _baseUrl + _artists + id + "/albums?market=" + Market;
            return ArtistRequest(uri).ToObject<PagingObject<AlbumSimple>>();
        }
    }
}
