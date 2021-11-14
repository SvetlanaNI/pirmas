using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Page
{
    public class ND4Page : BasePage
    {
        private const string PageAddress = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        private IWebElement FirstSelectedButton => Driver.FindElement(By.Id("printMe"));
        private IWebElement GetAllSelectedButton => Driver.FindElement(By.Id("printAll"));
        private SelectElement MultiDropDown => new SelectElement(Driver.FindElement(By.Id("multi-select")));
        public ND4Page(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }
		public ND4Page SelectFromTwoValue(string firstValue, string secondValue)
        {
			Actions action = new Actions(Driver);
			MultiDropDown.SelectByValue(firstValue);
			action.KeyDown(Keys.Control);
			MultiDropDown.SelectByValue(secondValue);
			action.KeyUp(Keys.Control);
			action.Build().Perform();
			return this;

		}
		

		public ND4Page SelectFromThreeValue(string firstValue, string secondValue, string thirdValue)
        {
			Actions action = new Actions(Driver);
			MultiDropDown.SelectByValue(firstValue);
			action.KeyDown(Keys.Control);
			MultiDropDown.SelectByValue(secondValue);
			MultiDropDown.SelectByValue(thirdValue);
			action.KeyUp(Keys.Control);
			action.Build().Perform();
			return this;
		}
        public ND4Page SelectFromFourValue(string firstValue, string secondValue, string thirdValue, string fourthValue)
        {
            Actions action = new Actions(Driver);
            MultiDropDown.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiDropDown.SelectByValue(secondValue);
			MultiDropDown.SelectByValue(thirdValue);
			MultiDropDown.SelectByValue(fourthValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;

        }
		public ND4Page ClickFirstSelectedButton()
		{
			FirstSelectedButton.Click();
			return this;
		}

		public ND4Page ClickAllSelectedButton()
		{
			GetAllSelectedButton.Click();
			return this;
		}

		public ND4Page SelectFromMultipleDropdownByValue(List<string> listOfStates)
		{
			MultiDropDown.DeselectAll();
			Actions action = new Actions(Driver);
			action.KeyDown(Keys.LeftControl);
			foreach (string state in listOfStates)
			{
				foreach (IWebElement option in MultiDropDown.Options)
				{
					if (state.Equals(option.GetAttribute("value")))
					{
						action.Click(option);
						break;
					}
				}
			}
			action.KeyUp(Keys.LeftControl);
			action.Build().Perform();
			action.Click(FirstSelectedButton);
			action.Build().Perform();
			return this;
		}

	}
}
