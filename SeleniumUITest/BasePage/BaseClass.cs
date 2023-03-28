using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
            //Create an instance for webdriver 
            driver = new ChromeDriver();
            //navigate
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
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
