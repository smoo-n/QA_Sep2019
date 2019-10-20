using OpenQA.Selenium;

namespace Google.Pages
{
    public class Result : MainPage
    {
        public Result(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FoundResult => Driver.FindElement(By.XPath(@"//*[@id='rso']/div[1]/div/div/div/div[1]/a[1]/h3"));

        public void Navigate(Search googleSearchPage)
        {
            googleSearchPage.Navigate("http://www.google.com");

            googleSearchPage.GoogleSearchBar.SendKeys("Selenium");
            googleSearchPage.GoogleSearchBar.Submit();
            FoundResult.Click();

        }


    }
}
