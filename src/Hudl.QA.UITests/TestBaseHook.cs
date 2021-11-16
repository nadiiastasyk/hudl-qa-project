using Hudl.QA.Infrastructure.Driver;
using TechTalk.SpecFlow;

namespace Hudl.QA.UITests
{
    [Binding]
    public sealed class TestBaseHooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.Quit();
        }
    }
}
