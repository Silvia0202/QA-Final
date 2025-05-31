
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace QAfinal
{
    [TestClass]
    public class TestLUD
    {

        private  IWebDriver driver;

        [TestInitialize]
        public void inicio()
        {
            driver = new FirefoxDriver(@"C:/webDrivers"); 
            
        }

        [TestCleanup]
        public void salir()
        {
            driver.Quit();
        }

        [TestMethod]
        public void TheUntitledTestCaseTest()
        {
            IWebDriver driver = new FirefoxDriver(@"C:/webDrivers");
            driver.Navigate().GoToUrl("https://www.letsusedata.com/");
            Thread.Sleep(4000);
            driver.FindElement(By.Id("txtUser")).Clear();
            driver.FindElement(By.Id("txtUser")).SendKeys("test1");
            driver.FindElement(By.Id("txtPassword")).Click();
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test12456");
            driver.FindElement(By.Id("javascriptLogin")).Click();
            Thread.Sleep(4000);
            Assert.IsTrue(driver.PageSource.Contains("Feedback Course 1"));
        }

        [TestMethod]
        public void TheUntitledTestCase2Test()
        {
            IWebDriver driver = new FirefoxDriver(@"C:/webDrivers");
            driver.Navigate().GoToUrl("https://www.letsusedata.com/");
            Thread.Sleep(4000);
            driver.FindElement(By.Id("txtUser")).Click();
            driver.FindElement(By.Id("txtPassword")).Click();
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test1234");
            driver.FindElement(By.Id("javascriptLogin")).Click();
            Thread.Sleep(8000);
            string loginButtonText = driver.FindElement(By.Id("javascriptLogin")).Text;
            Assert.AreEqual("Login", loginButtonText);
        }

    }
}
