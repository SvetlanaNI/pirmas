using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Test
{
    public class PakruojisShopTest
    {
        private static IWebDriver _driver;


        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parduotuve.pakruojo-dvaras.lt/");
            _driver.Manage().Window.Maximize();


            IWebElement popUp = _driver.FindElement(By.CssSelector("body > div.alcohol-notice.show > div.popup-container > div.notice-wrapper > div.button-wrapper > button.border-button.yes")); //kur taip 20 metu
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => popUp.Displayed);
            popUp.Click();


            IWebElement sutikimas = _driver.FindElement(By.CssSelector("body > div.cookies - message.show > div > div > div.button - wrapper > button"));
            WebDriverWait wait1 = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait1.Until(d => sutikimas.Displayed);
            sutikimas.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.CssSelector("#cookie-notice > div > div > button > span")).Click();

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit(); 
        }
    }
}
    

