using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.bing.com/";
            driver.Manage().Window.Maximize();
            var el = driver.FindElement(By.Id("sb_form_q"));
            el.SendKeys("Facebook");
            el.SendKeys(Keys.Return);
       
            Assert.AreEqual("Facebook - Търсене", driver.Title);

            driver.FindElement(By.LinkText("Facebook - Log In or Sign Up")).Click();
            var listOfElements = driver.FindElement(By.XPath("//*[@data-cookiebanner=\"accept_button\"]"));
            listOfElements.Click();

            WebElement email = (WebElement)driver.FindElement(By.Id("email"));
            email.SendKeys("nngjkngjn");
           // email.Clear();

            WebElement pass = (WebElement)driver.FindElement(By.Id("pass"));
            pass.SendKeys("kdjfj57");
            // pass.Clear();
            
            WebElement log = (WebElement)driver.FindElement(By.XPath("//*[@name=\"login\"]"));
            log.Click();
           
            //email.Submit();
            //pass.Submit();

        }

        [TearDown]
        public void closeBrowser()
        {
            //driver.Close();
        }

    }
}