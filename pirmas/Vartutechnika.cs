﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas
{
    class Vartutechnika
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
        public static void TestVartuTechnikaPage(string width, string height, bool automatika, bool montavimoDarbai, string result)
        {
             IWebElement widthInput = _driver.FindElement(By.Id("doors_width"));
             widthInput.Clear();
             widthInput.SendKeys(width);
             IWebElement heightInput = _driver.FindElement(By.Id("doors_height"));
             heightInput.Clear();
             heightInput.SendKeys(height);
             IWebElement autoCheckBox = _driver.FindElement(By.Id("automatika"));
            if (automatika != autoCheckBox.Selected)
                autoCheckBox.Click();
             IWebElement montavimoCheckBox = _driver.FindElement(By.Id("darbai"));
            if (montavimoDarbai != montavimoCheckBox.Selected)
                montavimoCheckBox.Click();
            _driver.FindElement(By.Id("calc_submit")).Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.CssSelector("#calc_result>div")).Displayed);
            IWebElement resultBox = _driver.FindElement(By.CssSelector("#calc_result>div"));
            Assert.IsTrue(resultBox.Text.Contains(result), $"Result is not the same, expected {result}, but was {resultBox.Text}");

        }

    }
}


