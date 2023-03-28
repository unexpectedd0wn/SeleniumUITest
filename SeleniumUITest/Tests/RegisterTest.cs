using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using SeleniumUITest.Support;

namespace SeleniumUITest.Tests
{
    [TestClass]
    public class RegisterTest : BaseClass
    {
        public HomePage homePage;
        public RegistrationPage registrationPage;
        string email = Support.Support.GenerateRandomEmail();

        [TestMethod]
        public void VerifyRegisterFunctionalityValidData()
        {
            homePage = new HomePage(driver);
            registrationPage = new RegistrationPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.clickRegisterLink();
            Assert.AreEqual(registrationPage.getTitle(), "Demo Web Shop. Register");
            registrationPage.selectGender();
            registrationPage.EnterFirstName("test");
            registrationPage.EnterLastName("test");
            registrationPage.EnterEmail(email);
            registrationPage.EnterPassword("testtest");
            registrationPage.ConfirmPassword("testtest");
            registrationPage.clickRegisterButton();
            string result = registrationPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registrationPage.IsEmailAccountDisplayed(email);
            Assert.IsTrue(isTrue);
            registrationPage.clickLogout();

        }
    }
}
