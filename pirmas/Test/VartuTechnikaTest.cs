using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using pirmas.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Test
{
    public class VartuTechnikaTest
    {
        private static IWebDriver _driver;

         [OneTimeSetUp]
         public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://vartutechnika.lt/";
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.Id("cookiescript_reject")).Click();

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }

        [TestCase("2000", "2000", true, false, "665.98", TestName = "2000 * 2000 + Vartu automatika = 665.98Eur")]
        [TestCase("4000", "2000", true, true, "1006.43", TestName = "4000 + 2000 + Vartu automatika + Vartu montavimo darbai" +
            " = 1006.43Eur")]
        [TestCase("4000", "2000", false, false, "692.35", TestName = "4000 + 2000 = 692.35Eur")]
        [TestCase("5000", "2000", false, true, "989.21", TestName = "5000 + 2000 + Vartu montavimo darbai = 989.21Eur")]

        public void TestVartuTechnika(string width, string height, bool automatika, bool montavimoDarbai, string result)
        {
            VartuTechnikaPage page = new VartuTechnikaPage(_driver);
            page.InsertWidthAndHeight(width, height)
            .CheckAutomatikCheckbox(automatika)
            .CheckMontavimoDarbaiCheckBox(montavimoDarbai)
            .ClickCalculateButton()
            .CheckResult(result);
        }


    }
}
