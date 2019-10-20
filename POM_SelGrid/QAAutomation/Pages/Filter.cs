using OpenQA.Selenium;


namespace QAAutomation.Pages
{
    public class Filter : BasePage
    {
        public Filter(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FoundResult => Driver.FindElement(By.XPath(@"/html/body/div[2]/header/h1"));


        public string Result()
        {
            var foundResult = FoundResult.Text;
            return foundResult;
        }
    }
}
