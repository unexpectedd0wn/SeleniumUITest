using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumUITest.WebDriverExtentions
{
    public static class WebDriverExtentions
    {
        //Common methods or re-usable methods for page
       

        public static void EnterText(this IWebDriver driver, By locator, string value)
        { 
            IWebElement element = driver.FindElement(locator);
            if (element.Displayed && element.Enabled)
            {
                element.Clear();
                element.SendKeys(value);
            }
        }

        public static void Click(this IWebDriver driver, By locator)
        {
            IWebElement element = driver.FindElement(locator);
            if (element.Displayed && element.Enabled)
            {
                element.Click();
                
            }
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator)
        {
            IWebElement element = driver.FindElement(locator);
            if (element.Displayed)
            {
                return true;

            }
            return false;
        }


        public static string getText(this IWebDriver driver, By locator)
        {
            IWebElement element = driver.FindElement(locator);
            var text = "";
            if (element.Displayed)
            {
                text = element.Text;
            }
            return text;
        }

        public static bool getTextWithValueDisplayed(this IWebDriver driver, string value)
        {
            var text = "";
            IWebElement element = driver.FindElement(By.XPath("//*[text()='" + value + "']"));
            if (element.Displayed)
            {
                return true;
            }
            return true;
        }

        public static void IsElementPresent()
        { 
        
        }

        public static void SelectByVisibletextFromDropDown()
        {

        }


    }
}
