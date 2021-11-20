using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Page
{
    public class PakruojisShopLastPage : BasePage
    {
        private const string PageAddress = "https://parduotuve.pakruojo-dvaras.lt/apmokejimas/";
        private IWebElement _suma => Driver.FindElement(By.CssSelector("#order_review > div.shop_table.woocommerce-checkout-review-order-table > div.table-footer > div.totals > div"));
        private IWebElement _pristatymas => Driver.FindElement(By.CssSelector("#shipping_method > li > label > div > span"));
        

        public PakruojisShopLastPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }
        public PakruojisShopLastPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
        

        public PakruojisShopLastPage WaitForSum()
        {
            WebDriverWait wait3 = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait3.Until(d => _suma.Displayed);
            return this;
        }
        
        
        public PakruojisShopLastPage CheckPristatymas()
        {
            WebDriverWait wait2 = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait2.Until(d => _pristatymas.Displayed);
            return this;
        }

    }
}
