using Hudl.QA.UITests.Entities;
using Hudl.QA.UITests.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Hudl.QA.UITests.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly HomePage _homePage;

        public LoginSteps(LoginPage loginPage, HomePage homePage)
        {
            _loginPage = loginPage;
            _homePage = homePage;
        }

        [Given(@"I am on the Login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _loginPage.GoToLoginPage();
        }

        [Given(@"click the Need help button")]
        public void GivenClickTheNeedHelpButton()
        {
            _loginPage.ClickNeedHelp();
        }

        [When(@"I fill in the required values")]
        public void WhenIFillInTheRequiredValues(Table table)
        {
            var credentials = table.CreateInstance<Credentials>();
            _loginPage.EnterEmail(credentials.Email);
            _loginPage.EnterPassword(credentials.Password);
        }

        [Given(@"email address is (.*)")]
        public void GivenEmailAddressIs(string email)
        {
            _loginPage.EnterEmail(email);
        }

        [Given(@"password is (.*)")]
        public void GivenPasswordIs(string password)
        {
            _loginPage.EnterPassword(password);
        }

        [When(@"click the Login button")]
        public void WhenClickTheLoginButton()
        {
            _loginPage.ClickLogin();
        }

        [When(@"click the Hudl logo")]
        public void WhenClickTheHudlLogo()
        {
            _loginPage.ClickLogo();
        }

        [When(@"click the Sign up button")]
        public void WhenClickTheSignUpButton()
        {
            _loginPage.ClickSignUp();
        }

        [Then(@"I am on the Home page")]
        public void ThenIAmOnTheHomePage()
        {
            _homePage.AssertCurrentPageIsHomePage();
        }

        [Then(@"I am on the Login page")]
        public void ThenIAmOnTheLoginPage()
        {
            _loginPage.AssertCurrentPageIsLoginPage();
        }

        [Then(@"I am on the Home page not logged in")]
        public void ThenIAmOnTheHomePageNotLoggedIn()
        {
            _homePage.AssertCurrentPageIsHomeNotLoggedInPage();
        }

        [Then(@"the message is shown: (.*)")]
        public void ThenTheMessageIsShown(string message)
        {
            _loginPage.AssertInvalidCredentialsMessage(message);
        }
    }
}
