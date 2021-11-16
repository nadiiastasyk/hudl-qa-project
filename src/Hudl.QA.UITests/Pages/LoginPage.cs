using FluentAssertions;
using Hudl.QA.Infrastructure.Driver;
using OpenQA.Selenium;
using WebElement = Hudl.QA.Infrastructure.Components.WebElement;

namespace Hudl.QA.UITests.Pages
{
    public class LoginPage
    {

        private IWebElement Login => new WebElement().GetById("logIn");

        private IWebElement Email => new WebElement().GetById("email");

        private IWebElement Password => new WebElement().GetById("password");

        private IWebElement ForgotPassword => new WebElement().GetById("forgot-password-link");

        private IWebElement NeedHelp => new WebElement().GetByCssSelector(".need-help");

        private IWebElement Logo => new WebElement().GetByCssSelector(".icon-logomark");

        private IWebElement SignUp => new WebElement().GetByLinkText("Sign up");

        private IWebElement ErrorContainer => new WebElement().GetByXPath("//div[@class='login-error-container']/p");


        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void GoToLoginPage()
        {
            WebDriverUtils.GoToUrl("https://www.hudl.com/login");
        }

        public void ClickLogin()
        {
            Login.Click();
        }

        public void AssertCurrentPageIsLoginPage()
        {
            // TODO: Add wait until visible
            WebDriver.GetDriver().Url.Should().Be("https://www.hudl.com/login");
        }

        public void ClickLogo()
        {
            Logo.Click();
        }

        public void ClickNeedHelp()
        {
            NeedHelp.Click();
        }

        public void ClickSignUp()
        {
            SignUp.Click();
        }

        public void AssertInvalidCredentialsMessage(string message)
        {
            ErrorContainer.GetAttribute("innerText").StartsWith(message);
        }
    }
}
