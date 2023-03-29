using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;

namespace SeleniumUITest.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        HomePage homePage;
        
        [TestCategory("SmokeTest")]
        [TestMethod]
        public void TestMethod1()
        {

            homePage = new HomePage(driver);

        }
    }
}
