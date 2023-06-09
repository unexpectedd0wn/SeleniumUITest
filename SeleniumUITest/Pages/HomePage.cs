﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumUITest.WebDriverExtentions;

namespace SeleniumUITest.Pages
{
    public class HomePage
    {
        //Instance of the driver
        public static IWebDriver driver;
        //Create a constructor 
        public HomePage(IWebDriver driver)
        { 
            HomePage.driver = driver;
        }

        public string getTitle()
        {
            return driver.Title;
        }
        /*
         * Page objects - for webelements
         */

        public static readonly By registerLink = By.ClassName("ico-register");
        public static readonly By loginLink = By.ClassName("ico-login");

        public void clickRegisterLink()
        {
            driver.Click(registerLink);

        }
        public void clickLoginLink()
        {
            driver.Click(loginLink);
        }
    }
}
