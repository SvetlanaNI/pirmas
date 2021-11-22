using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Page
{
    public class PakruojisShopFourthPage : BasePage
    {
        private const string PageAddress = "https://parduotuve.pakruojo-dvaras.lt/krepselis/";
        private IWebElement _toliau => Driver.FindElement(By.CssSelector(".next-step > .button"));
        private IWebElement _krepselis => Driver.FindElement(By.XPath("/html/body/header/div[1]/div/div[2]/a"));

        public PakruojisShopFourthPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }
        
        public PakruojisShopFourthPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }


        public PakruojisShopFourthPage Next()
        {
            _toliau.Click();
            return this;
        }
        public PakruojisShopFourthPage Basket()
        {
            _krepselis.Click();
            return this;

        }

        
        
    }
}
