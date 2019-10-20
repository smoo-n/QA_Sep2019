using OpenQA.Selenium;

namespace Google.Pages
{
    public class Search : MainPage
    {
        public Search(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GoogleSearchBar => Driver.FindElement(By.Name("q"));


    }
}
