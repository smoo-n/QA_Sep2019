using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace AutoReg
{
    [TestFixture]
    public class AutoReg
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegUser _user;
        private ChromeDriver _driver;

        [SetUp]
        public void ClassInit()
        {
            ChromeOptions options = new ChromeOptions();

            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            _driver = new RemoteWebDriver(new Uri("http://192.168.1.101:1259/wd/hub"), options
                .ToCapabilities(), TimeSpan.FromSeconds(50));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);

            _loginPage = new LoginPage(_driver);
            _regPage = new RegistrationPage(_driver);

            _user = UserInfo.CreateValidUser();
        }

        [Test]
        public void AutomationpracticeRegPageOpen()
        {

            _regPage.Navigate(_loginPage);

            var registrationAssertion = _driver.FindElement(By.XPath(@"//*[@id='account-creation_form']/div[1]/h3"));

            Assert.AreEqual("YOUR PERSONAL INFORMATION", registrationAssertion.Text);

        }

        [Test]
        public void EmptyFirstNameField()
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("firstname is required.");
        }
        [Test]
        public void EmptyLastNameField()
        {
            _user.LastName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("lastname is required.");
        }
        [Test]
        public void EmptyAddressField()
        {
            _user.Address = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("address1 is required.");
        }
        [Test]
        public void EmptyPasswordField()
        {
            _user.Password = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("passwd is required.");
        }
        [Test]
        public void EmptyCityField()
        {
            _user.City = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("city is required.");
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
