using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Page
{
    public class PakruojisShopThirdPage : BasePage
    {

        private const string PageAddress = "https://parduotuve.pakruojo-dvaras.lt/produkto-kategorija/spirito-varykla/";
        private IWebElement _klevuTrauktine => Driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[7]/div/div/a"));
        private IWebElement _eitiIKrepseli => Driver.FindElement(By.CssSelector(".xoo-cp-btn-vc"));
      

        public PakruojisShopThirdPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }

        public PakruojisShopThirdPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        
        public PakruojisShopThirdPage ClickKlevu()
        {
            _klevuTrauktine.Click();
            return this;
        }

        public PakruojisShopThirdPage ClickBuyingAllThings()
        {
            _eitiIKrepseli.Click();
            return this;
        }
        






    }
}
    
        