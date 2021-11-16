using Hudl.QA.Infrastructure.Driver;
using OpenQA.Selenium;

namespace Hudl.QA.Infrastructure.Components
{
    public class WebElement
    {
        private readonly IWebDriver _webDriver = WebDriver.GetDriver();

        public IWebElement GetById(string id) => _webDriver.FindElement(By.Id(id));

        public IWebElement GetByCssSelector(string cssSelector) => _webDriver.FindElement(By.CssSelector(cssSelector));

        public IWebElement GetByXPath(string xPath) => _webDriver.FindElement(By.XPath(xPath));

        public IWebElement GetByLinkText(string text) => _webDriver.FindElement(By.LinkText(text));

        public IWebElement GetByPartialLinkText(string text) => _webDriver.FindElement(By.PartialLinkText(text));

        public IWebElement GetByTagName(string tag) => _webDriver.FindElement(By.TagName(tag));
    }
}
