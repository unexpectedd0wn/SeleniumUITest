using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;

namespace SeleniumUITest.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        HomePage homePage;
        LoginPage loginPage;
        
        [TestCategory("SmokeTest")]
        [TestMethod]
        public void TestMethod1()
        {

            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);  
            homePage.clickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(Support.Support.GenerateRandomEmail());
            loginPage.EnterPassword("test");
            loginPage.ClickLogInButton();
        }
    }
}
