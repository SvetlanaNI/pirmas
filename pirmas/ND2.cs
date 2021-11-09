using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas
{
    class _2ND
    {
        private static IWebDriver _driver;
        private static string _textToCheck;

        [TestCase("Chrome", "Chrome", TestName = "Chrome test")]
        [TestCase("Edge", "Chrome", TestName = "Edge test")]



        public static void TestBrowsers(string browser, string visibleText)
        {
            switch (browser)
            {
                case "Chrome":
                    _driver = new ChromeDriver();
                    _textToCheck = visibleText;
                    break;
                case "Edge":
                    _driver = new EdgeDriver();
                    _textToCheck = visibleText;
                    break;
            }

            SetUp();
            string textOnPage = _driver.FindElement(By.CssSelector("#primary-detection>div")).Text;
            Assert.IsTrue(textOnPage.Contains(_textToCheck), "Text is not present");
            TearDown();
        }

        private static void SetUp()
        {
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }
           
       private static void TearDown()
        {
            _driver.Quit();
        }
    }
}
