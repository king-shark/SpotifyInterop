using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotifyInterop;
using System.Configuration;
using System.Collections.Specialized;

namespace SpotifyInteropTest
{
    [TestClass]
    public class SpotifyClientTest
    {
        [TestMethod]
        public void DoesGetAuthToken()
        {
            SpotifyClient sc = new SpotifyClient(new SpotifyInterop.Models.SpotifyCredentials(ConfigurationManager.AppSettings["clientId"], ConfigurationManager.AppSettings["clientSecret"]));
            sc.getauthtoken();

            Assert.IsNotNull(sc.AccessToken);
        }
    }
}
