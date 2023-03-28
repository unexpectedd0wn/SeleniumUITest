using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUITest
{
    [TestClass]
    public class SampleTest
    {
        string email = GenerateRandomEmail();
        

        [TestMethod]
        public void TestMethod1()
        {

            try
            {
                
                string title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");

                driver.FindElement(By.ClassName("ico-register")).Click();
                driver.FindElement(By.Id("gender-male")).Click();
                driver.FindElement(By.Id("FirstName")).SendKeys("testest");
                driver.FindElement(By.Id("LastName")).SendKeys("testest");

                driver.FindElement(By.Id("Email")).SendKeys(email);
                Console.WriteLine(email);

                driver.FindElement(By.Id("Password")).SendKeys("testest");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("testest");

                driver.FindElement(By.Id("register-button")).Click();

                String message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registeretion complited");

                IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailAccount.Displayed);

                driver.FindElement(By.ClassName("ico-logout")).Click();
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


        }


        [TestCleanup]
        public void closeBrowser()
        {
            driver.Close();
        }



        public static string GenerateRandomEmail()
        {
            return string.Format("{0}{1}@{2}.com","sotwaretesteranna+", GenerateRandomNumberString(3), "testdomain");
        }

        

        public static string GenerateRandomNumberString(int length)
        {
            string allowedChars = "abcd1234567890";
            var rnd = SeedRandom();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = allowedChars[rnd.Next(allowedChars.Length)];
            }

            return new string(chars);
        }

        private static Random SeedRandom()
        {
            return new Random(Guid.NewGuid().GetHashCode());
        }
    }
}
