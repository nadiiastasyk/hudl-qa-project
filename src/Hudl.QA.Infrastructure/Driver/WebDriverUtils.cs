namespace Hudl.QA.Infrastructure.Driver
{
    public class WebDriverUtils
    {
        public static void GoToUrl(string url)
        {
            WebDriver.GetDriver().Navigate().GoToUrl(url);
        }
    }
}
