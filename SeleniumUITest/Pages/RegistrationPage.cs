using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumUITest.Pages
{
    public class RegistrationPage
    {
        //Instance of the driver
        public static IWebDriver driver;
        //Create a constructor
        public RegistrationPage(IWebDriver driver)
        {
           RegistrationPage.driver = driver;
        }

        public string getTitle()
        {
            return driver.Title;
        }
        /*
         * Page object
         */

        public static readonly By genderMale = By.Id("gender-male");
        public static readonly By firstName = By.Id("FirstName");
        public static readonly By lastName = By.Id("LastName");
        public static readonly By email = By.Id("Email");
        public static readonly By password = By.Id("Password");
        public static readonly By confirmPassword = By.Id("ConfirmPassword");
        public static readonly By registerButton = By.Id("register-button");

        public static readonly By result = By.ClassName("result");
        public static readonly By status = By.ClassName("status");
        public static readonly By logout = By.ClassName("ico-logout");
        public static readonly By passwordMessage = By.CssSelector(".field-validation-error > span");

        /*
         * page Methods
         * 
         */
        public void selectGender()
        { 
            driver.FindElement(genderMale).Click();
        }

        public void EnterFirstName(string value)
        {
            driver.FindElement(firstName).SendKeys(value);
        }
        public void EnterLastName(string value)
        {
            driver.FindElement(lastName).SendKeys(value);
        }

        public void EnterEmail(string value)
        {
            driver.FindElement(email).SendKeys(value);
        }

        public void EnterPassword(string value)
        {
            driver.FindElement(password).SendKeys(value);
        }

        public void ConfirmPassword(string value)
        {
            driver.FindElement(confirmPassword).SendKeys(value);
        }

        public void clickRegisterButton()
        {
            driver.FindElement(registerButton).Click();
        }

        public string GetSuccessfullMessage()
        {
            return driver.FindElement(result).Text;
        }
        public string GetValidationMessagePaaswordIsShort()
        {
            return driver.FindElement(passwordMessage).Text;
        }

        public bool IsEmailAccountDisplayed(string email)
        {
           return driver.FindElement(By.XPath("//*[text()='" + email + "']")).Displayed;
        }

        public void clickLogout()
        {
            driver.FindElement(logout).Click();
        }
    }
}
