using OpenQA.Selenium;

namespace QAAutomation.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public virtual void Navigate(string url)
        {
            Driver.Url = url;
        }

    }
}
