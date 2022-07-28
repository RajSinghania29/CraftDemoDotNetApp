using System.Collections.Generic;

using CraftDemonstration;

using NUnit.Framework;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateimageUri_WithValidParameters_VerifyImageUriCreated()
        {
            int farm = 1;
            string server = "av";
            string secret = "fd";
            string id = "hd";
            var list = new List<string>();
            var exp = $"http://farm{farm}.staticflickr.com/{server}/{id}_{secret}.jpg";
            var a = new DesktopApplication();
            Assert.AreEqual(a.CreateimageUri(farm, server, secret, id), exp);
        }

        [Test]
        public void GetFlickrApiUrl_WithValidSearchString_VerifyFlickrApiUrlReturned()
        {
            string searchString = "man";
            var a = new DesktopApplication();
            var exp =
                $"https://api.flickr.com/services/rest/?format=json&method=flickr.photos.search&api_key=793bf235e9b0d2640da1985f77d524d6&tags=%27+{searchString}+%27&jsoncallback=?";
            Assert.AreEqual(exp, a.GetFlickrApiUrl(searchString));

        }
    }
}