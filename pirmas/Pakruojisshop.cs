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
    class Pakruojisshop
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
            _driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/button/span[1]/svg")).Click();
            
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
           // _driver.Quit();
        }
        [Test]
        public static void BuyThings()
        {
            _driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[1]/div/div/a")).Click();
            _driver.FindElement(By.XPath("/html/body/div[5]/div/div[2]/div[3]/a[1]")).Click();
            _driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[2]/div/div/a")).Click();
            _driver.FindElement(By.XPath("/html/body/div[5]/div/div[2]/div[3]/a[1]")).Click();
            _driver.FindElement(By.XPath("/html/body/header/div[1]/div/div[2]/a")).Click();
            _driver.FindElement(By.XPath("/html/body/div[3]/div/div/form/div[2]/a")).Click();
            
        }
    }
}
