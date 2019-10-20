using NUnit.Framework;

namespace Google.Pages
{
    public partial class GoogleSerach
    {
        public void FoundResult(string foundResult)
        {
            Assert.AreEqual("Selenium - Web Browser Automation", foundResult);
        }
    }
}
