using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using pirmas.Drivers;
using pirmas.Page;
using pirmas.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pirmas.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
       //public static DropDownPage _dropDownPage;
       //public static VartuTechnikaPage _vartuTechnikaPage;
        public static PakruojisShopMainPage _pakruojisShopMainPage;
        public static PakruojisShopSecondPage _pakruojisShopSecondPage;
        public static PakruojisShopThirdPage _pakruojisShopThirdPage;
        public static PakruojisShopFourthPage _pakruojisShopFourthPage;
        public static PakruojisShopLastPage _pakruojisShopLastPage;


        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            driver.Navigate().GoToUrl("https://parduotuve.pakruojo-dvaras.lt/");

            driver.FindElement(By.CssSelector("body > div.alcohol-notice.show > div.popup-container > div.notice-wrapper"));
            driver.FindElement(By.CssSelector("body > div.alcohol-notice.show > div.popup-container > div.notice-wrapper > div.button-wrapper > button.border-button.yes")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement cookie = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/button"));
            Thread.Sleep(5000);
            cookie.Click();

            // _dropDownPage = new DropDownPage(driver);
            // _vartuTechnikaPage = new VartuTechnikaPage(driver);

            _pakruojisShopMainPage = new PakruojisShopMainPage(driver);
            _pakruojisShopSecondPage = new PakruojisShopSecondPage(driver);
            _pakruojisShopThirdPage = new PakruojisShopThirdPage(driver);
            _pakruojisShopFourthPage = new PakruojisShopFourthPage(driver);
            _pakruojisShopLastPage = new PakruojisShopLastPage(driver);

        }
        [TearDown]
        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }






           
    }
}
