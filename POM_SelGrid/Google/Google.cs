using Google.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace Google
{
    [TestFixture]
    public partial class GoogleSearchTest
    {
        private ChromeDriver _driver;
        private Search _googleSearchPage;
        private Result _googleResultsPage;

        [SetUp]
        public void SelSearcInit()
        {
            ChromeOptions options = new ChromeOptions();

            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            _driver = new RemoteWebDriver(new Uri("http://192.168.1.101:1259/wd/hub"), options
                .ToCapabilities(), TimeSpan.FromSeconds(50));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);

            _googleSearchPage = new Search(_driver);
            _googleResultsPage = new Result(_driver);

        }

        [Test]
        public void SeleniumSearch()
        {
            _googleResultsPage.Navigate(_googleSearchPage);
            var foundResult = _driver.Title;

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
