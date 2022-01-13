// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_CSharp_Project.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Selenium_CSharp_Project
{
    [TestFixture]
    public class TestClass: BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

            // Akceptuje ciasteczka
            driver.FindElement(By.XPath(".//button[@data-cookiebanner='accept_button']")).Click();
            Thread.Sleep(1000);

            // Możliwe ścieżki dla button zarejestruj

            //.//*[@data-testid='open-registration-form-button']
            //.//*[text()='Utwórz nowe konto']
            //.//*[@class='_6ltg'][2]

            driver.FindElement(By.XPath(".//*[@class='_6ltg'][2]")).Click();
            Thread.Sleep(1000);

            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(4);
            Thread.Sleep(1000);
            //Tylko jeśli używamy w języku polskim
            element.SelectByText("lip");
            Thread.Sleep(1000);
            element.SelectByValue("11");
            Thread.Sleep(1000);
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(3000);
        }
    }
}
