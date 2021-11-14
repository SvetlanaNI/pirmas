using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pirmas
{
    class PakruojisDraft
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parduotuve.pakruojo-dvaras.lt/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.CssSelector("body > div.alcohol-notice.show > div.popup-container > div.notice-wrapper"));
            _driver.FindElement(By.CssSelector("body > div.alcohol-notice.show > div.popup-container > div.notice-wrapper > div.button-wrapper > button.border-button.yes")).Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement cookie = _driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/button"));
            Thread.Sleep(5000);
            cookie.Click();

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Quit();
        }




        [Test]
        public static void BuyThings()
        {
            _driver.FindElement(By.CssSelector("body > header > div.wrapper > div > div.right-side > div.burger")).Click();


            /*
            _driver.FindElement(By.XPath("body")).Click();
            _driver.FindElement(By.XPath("/html/body")).Click();
            _driver.FindElement(By.CssSelector("#menu-item-913 > a")).Click();
            _driver.FindElement(By.XPath("/html/body/div[5]/div/div[2]/div[3]/a[1]")).Click();
            */

        }

    }

}
    

