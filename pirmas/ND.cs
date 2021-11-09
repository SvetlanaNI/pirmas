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
    class ND
    {
        [Test]
        public static void TestSeleniumDuPliusDu()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();
            IWebElement enteraField = chrome.FindElement(By.Id("sum1"));
            enteraField.SendKeys("2");
            IWebElement enterbField = chrome.FindElement(By.Id("sum2"));
            enterbField.SendKeys("2");
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("4", result.Text, "2+2 is not equal 4");
        }

        [Test]
        public static void TestSeleniumMinusTrysPliusPenki()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();
            IWebElement enteraField = chrome.FindElement(By.Id("sum1"));
            enteraField.SendKeys("-5");
            IWebElement enterbField = chrome.FindElement(By.Id("sum2"));
            enterbField.SendKeys("3");
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal>button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("-2", result.Text, "-3 + 5 is not equal -2");
        }
        [Test]
        public static void TestSeleniumAPliusB()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();
            IWebElement enteraField = chrome.FindElement(By.Id("sum1"));
            enteraField.SendKeys("a");
            IWebElement enterbField = chrome.FindElement(By.Id("sum2"));
            enterbField.SendKeys("b");
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal>button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("NaN", result.Text, "a + b is not equal NaN");
        }
    }

 }

