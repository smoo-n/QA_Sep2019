using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using QAAutomation.Pages;
using System;
namespace QAAutomation
{
    [TestFixture]
    public class QAAutomationAssert
    {
        private ChromeDriver _driver;
        private EntryPage _EntryPage;
        private Filter _Filter;

        [SetUp]
        public void CalssInit()
        {
            ChromeOptions options = new ChromeOptions();

            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            _driver = new RemoteWebDriver(new Uri("http://192.168.1.101:1259/wd/hub"), options
                .ToCapabilities(), TimeSpan.FromSeconds(50));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);

            _EntryPage = new EntryPage(_driver);
            _Filter = new Filter(_driver);
        }

        [Test]
        public void QAAutomationCurs()
        {
            _EntryPage.Navigate();

            Assert.AreEqual(_Filter.Result(), "QA Automation - септември 2019");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
