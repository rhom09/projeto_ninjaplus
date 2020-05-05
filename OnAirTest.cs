using NUnit.Framework;
using Coypu;
using Coypu.Drivers.Selenium;

namespace ninjaplus_net
{
    public class OnAirTest
    {
        [SetUp]
        public void ShouldBeHaveTitle()
        {
        }

        [Test]
        public void Test1()
        {
            var configs = new SessionConfiguration
            {
                AppHost = "http://ninjaplus-web",
                Port = 5000,
                SSL = false,
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome
            };

            var browser = new BrowserSession(configs);

            browser.Visit("/login");

            Assert.AreEqual("Ninja+", browser.Title);
            browser.Dispose();
        }
    }
}