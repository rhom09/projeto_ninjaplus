using NUnit.Framework;
using Coypu;
using Coypu.Drivers.Selenium;

namespace ninjaplus.Tests
{
    public class OnAirTest
    {

        public BrowserSession browser;

        [SetUp]
        public void Setup()
        {

            var configs = new SessionConfiguration
            {
                AppHost = "http://ninjaplus-web",
                Port = 5000,
                SSL = false,
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome
            };

            browser = new BrowserSession(configs);
        }

        [Test]
        public void ShouldBeHaveTitle()
        {
            browser.Visit("/login");
            Assert.AreEqual("Ninja+", browser.Title);
        }

        [TearDown]
        public void Finish()
        {
            browser.Dispose();
        }
    }
}