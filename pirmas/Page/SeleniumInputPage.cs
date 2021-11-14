using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Page
{
    public class SeleniumInputPage
    {
        private static IWebDriver _driver;

        private static IWebElement _inputfield => _driver.FindElement(By.Id("user-message"));
        private static IWebElement _button => _driver.FindElement(By.CssSelector("#get-input > button"));
        private static IWebElement _result => _driver.FindElement(By.Id("display"));
        private IWebElement _firstInput => _driver.FindElement(By.Id("sum1"));
        private IWebElement _secondInput => _driver.FindElement(By.Id("sum2"));
        private IWebElement _getTotalButton => _driver.FindElement(By.CssSelector("#gettotal > button"));
        private IWebElement _resultFromPage => _driver.FindElement(By.Id("displayvalue"));

        public SeleniumInputPage (IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void InsertText(string text)
        {
            _inputfield.Clear();
            _inputfield.SendKeys(text);
        }

        public void ClickShowMessageButton()
        {
            _button.Click();
        }

        public void CheckResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _result, "Tekstas neatsirado");
                
        }
        public void InsertFirstInput(string text)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(text);
        }
        public void InsertSecondInput(string text)
        {
            _secondInput.Clear();
            _secondInput.SendKeys(text);
        }

       
        public void InsertBothInputs(string first, string second)
        {
            InsertFirstInput(first);
            InsertSecondInput(second);
        }
        public void ClickGetTotalButton()
        {
            _getTotalButton.Click();
        }






    }
}
