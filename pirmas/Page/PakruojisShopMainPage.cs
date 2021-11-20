using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pirmas.Page
{
    public class PakruojisShopMainPage : BasePage
    {
        private const string PageAddress = "https://parduotuve.pakruojo-dvaras.lt/";

        
       /* private IWebElement _popUp => Driver.FindElement(By.CssSelector("body > div.alcohol-notice.show > div.popup-container > div.notice-wrapper > div.button-wrapper > button.border-button.yes")); //kur taip 20 metu
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        private IWebElement _sutikimas => Driver.FindElement(By.CssSelector("body > div.alcohol-notice.show > div.popup-container > div.notice-wrapper > div.button-wrapper > button.border-button.yes"));
        WebDriverWait _wait1 = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        private IWebElement _cookie => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/button"));
        WebDriverWait wait3 = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));*/
        
        private IWebElement _visosPrekes => Driver.FindElement(By.CssSelector("#menu-item-503 > a"));
        

        


        public PakruojisShopMainPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }
        public PakruojisShopMainPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
       /* public PakruojisShopPage1 ClosePopUp()
        {
            _sutikimas.Click();
            return this;
            
        }
        public PakruojisShopPage1 CloseCookie()
        {
            _cookie.Click();
            return this;
        }*/

        public PakruojisShopMainPage StartBuying()
        {
            _visosPrekes.Click();
            return this;
        }

        

    }

}
    


    

