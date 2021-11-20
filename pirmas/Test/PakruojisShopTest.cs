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
    class PakruojisShopTest : BaseTest
    {
      
        
        [Test]
        public void CheckOneThing()
        {
            _pakruojisShopMainPage.NavigateToDefaultPage()
                .StartBuying();
            _pakruojisShopSecondPage.NavigateToDefaultPage()
                .ClickPlate();
        }
        
        [Test]
        public void CheckTwoThings()
        {
            _pakruojisShopMainPage.NavigateToDefaultPage()
                .StartBuying();
            _pakruojisShopSecondPage.NavigateToDefaultPage()
                .ClickPlate()
                .ClickContinue()
                .ClickSpirit();
            _pakruojisShopThirdPage.NavigateToDefaultPage()
                .ClickKlevu();
        }
        
        [Test]
        public void CheckDeliveryPriceOfPlate()
        {
            _pakruojisShopMainPage.NavigateToDefaultPage()
                .StartBuying();
            _pakruojisShopSecondPage.NavigateToDefaultPage()
                .ClickPlate()
                .ClickIKrepseli()
                .ClickNext();
            _pakruojisShopLastPage.NavigateToDefaultPage()
                .CheckPristatymas();
        }
        
        [Test]
        public void CheckDeliveryPriceOfMapleBitter()
        {
            _pakruojisShopMainPage.NavigateToDefaultPage()
                .StartBuying();
            _pakruojisShopSecondPage.NavigateToDefaultPage()
                .ClickSpirit();
            _pakruojisShopThirdPage.NavigateToDefaultPage()
                .ClickKlevu()
                .ClickBuyingAllThings();
            _pakruojisShopFourthPage.NavigateToDefaultPage()
                .Toliau();
            _pakruojisShopLastPage.NavigateToDefaultPage()
                .CheckPristatymas();
        }
        
        [Test]
        public void CheckSumBuyingPlate()
        {
            _pakruojisShopMainPage.NavigateToDefaultPage()
               .StartBuying();
            _pakruojisShopSecondPage.NavigateToDefaultPage()
                .ClickPlate()
                .ClickIKrepseli()
                .ClickNext();
            _pakruojisShopLastPage.NavigateToDefaultPage()
                .WaitForSum();
         }

        [Test]
        public void CheckSumBuyingKlevu()
        {
            _pakruojisShopMainPage.NavigateToDefaultPage()
                .StartBuying();
            _pakruojisShopSecondPage.NavigateToDefaultPage()
               .ClickSpirit();
            _pakruojisShopThirdPage.NavigateToDefaultPage()
                .ClickKlevu()
                .ClickBuyingAllThings();
            _pakruojisShopFourthPage.NavigateToDefaultPage()
                .Toliau();
            _pakruojisShopLastPage.NavigateToDefaultPage()
                .WaitForSum();

        }

            
    }
}

    

