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

        public static IWebDriver driver;
        RegistrationPage(IWebDriver driver)
        {
           RegistrationPage.driver = driver;
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

        /*
         * page Methods
         * 
         */
        public void selectGender()
        { 
            driver.FindElement(genderMale).Click();
        }

    }
}
