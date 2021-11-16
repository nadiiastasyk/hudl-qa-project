using FluentAssertions;
using Hudl.QA.Infrastructure.Driver;

namespace Hudl.QA.UITests.Pages
{
    public class HomePage
    {
        public void AssertCurrentPageIsHomePage()
        {
            WebDriver.GetDriver().Url.Should().Be("https://www.hudl.com/home");
        }

        public void AssertCurrentPageIsHomeNotLoggedInPage()
        {
            WebDriver.GetDriver().Url.Should().Be("https://www.hudl.com/en_gb/");
        }       
    }
}
