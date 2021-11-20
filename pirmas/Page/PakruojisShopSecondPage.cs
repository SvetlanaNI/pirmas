using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Page
{
    public class PakruojisShopSecondPage : BasePage
    {
        private const string PageAddress = "https://parduotuve.pakruojo-dvaras.lt/parduotuve/";

        private IWebElement _lekste => Driver.FindElement(By.CssSelector(".post-944 .button"));
        private IWebElement _testi => Driver.FindElement(By.CssSelector(".xoo-cp-close:nth-child(1)"));
        private IWebElement _iKrepseli => Driver.FindElement(By.CssSelector(".xoo-cp-btn-vc"));
        private IWebElement _toliau => Driver.FindElement(By.CssSelector(".next-step > .button"));
        private IWebElement _spiritoVarykla => Driver.FindElement(By.CssSelector("#menu-item-168 > a"));


        public PakruojisShopSecondPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }
        public PakruojisShopSecondPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
       



        public PakruojisShopSecondPage ClickPlate()
        {
            _lekste.Click();
            return this;
        }
        public PakruojisShopSecondPage ClickContinue()
        {
            _testi.Click();
            return this;
        }
        public PakruojisShopSecondPage ClickSpirit()
        {
            _spiritoVarykla.Click();
            return this;
        }

        public PakruojisShopSecondPage ClickIKrepseli()
        {
            _iKrepseli.Click();
            return this;
        }
        public PakruojisShopSecondPage ClickNext()
        {
            _toliau.Click();
            return this;
                
        }
        
        
        
        
    }
}
