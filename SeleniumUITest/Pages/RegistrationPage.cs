using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumUITest.WebDriverExtentions;

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
            
            driver.Click(genderMale);
        }

        public void EnterFirstName(string value)
        {
            
            driver.EnterText(firstName,value);
        }
        public void EnterLastName(string value)
        {
            driver.EnterText(lastName, value);
        }

        public void EnterEmail(string value)
        {
            driver.EnterText(email,value);
        }

        public void EnterPassword(string value)
        {
            driver.EnterText(password, value);
        }

        public void ConfirmPassword(string value)
        {
            driver.EnterText(confirmPassword, value);
        }

        public void clickRegisterButton()
        {
            driver.Click(registerButton);
        }

        public string GetSuccessfullMessage()
        {
           return driver.getText(result);
        }
        public string GetValidationMessagePaaswordIsShort()
        {
            return driver.getText(passwordMessage); ;
        }

        public bool IsEmailAccountDisplayed(string email)
        {
           return driver.getTextWithValueDisplayed(email);
        }

        public void clickLogout()
        {
            driver.Click(logout);
        }
    }
}
