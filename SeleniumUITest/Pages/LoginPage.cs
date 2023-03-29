using OpenQA.Selenium;
using SeleniumUITest.WebDriverExtentions;

namespace SeleniumUITest.Pages
{
    public class LoginPage
    {
        public static IWebDriver driver;

        public LoginPage(IWebDriver driver)
        { 
            LoginPage.driver = driver;
        }


        public string getTitle()
        { 
            return driver .Title;
        }

        public static readonly By emailtxt = By.Id("Email");
        public static readonly By passwordtxt = By.Id("Password");
        public static readonly By loginBtn = By.CssSelector("input.button-1.login-button");

        public void EnterEmailAddress(string email)
        {
            driver.EnterText(emailtxt, email);
        }

        public void EnterPassword(string password)
        {
            driver.EnterText(passwordtxt, password);
        }

        public void ClickLogInButton()
        {
            driver.Click(loginBtn);
        }
    }
}
