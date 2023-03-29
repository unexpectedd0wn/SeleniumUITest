using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;


namespace SeleniumUITest.BasePage
{
    /*
     * Initialize the driver - Setup driver
     * Re-usable methods
     * 
     */
    public class BaseClass
    {
        public static WebDriver driver;
        

        [TestInitialize]
        public void Init()
        {

            string url = ConfigurationManager.AppSettings["url"];
            //Create an instance for webdriver 
            driver = new ChromeDriver();
            //navigate
            driver.Navigate().GoToUrl(url);
            //Maximaze browser window
            driver.Manage().Window.Maximize();

        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
