using Coypu;
using Coypu.Drivers.Selenium;
using NUnit.Framework;

namespace NinjaPlus.Tests
{
    public class LoginTests
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

        [TearDown]
        public void Finish()
        {
            browser.Dispose();
        }

        [Test]
        [Category("critical")]
        public void SuccessfullyLogin()
        {
            browser.Visit("/login");

            browser.FillIn("emailId").With("papito@ninjaplus.com");
            browser.FindCss("input[placeholder=senha]").SendKeys("pwd123");
            browser.ClickButton("login");

            var loggedUser = browser.FindCss(".user .info span");
            Assert.AreEqual("Papito", loggedUser.Text);
        }
    }
}