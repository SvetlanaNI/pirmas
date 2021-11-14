using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using pirmas.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Test
{
    public class ND4Test
    {
        private static ND4Page _page;
        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new ND4Page(driver);
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            _page.CloseBrowser();
        }


        [TestCase("New York", "Texas", TestName = "First selected option is New York")]
        public void TestTwoStatesWithFirstSelected(string firstValue, string secondValue)
        {
            _page.SelectFromTwoValue(firstValue, secondValue)
            .ClickFirstSelectedButton();
        }
        [TestCase("New York", "Texas", TestName = "All selected options are New York and Texas")]
        public void TestTwoStatesWithAllSelected(string firstValue, string secondValue)
        {
            _page.SelectFromTwoValue(firstValue, secondValue)
                        .ClickAllSelectedButton();
        }
        [TestCase("Florida", "Texas", "Ohio", TestName = "First selected option is Florida")]
        public void TestThreeStatesWithFirstSelected(string firstValue, string secondValue, string thirdValue)
        {
            _page.SelectFromThreeValue(firstValue, secondValue, thirdValue)
            .ClickFirstSelectedButton();
        }
        [TestCase("New York", "Texas", "Ohio", "California", TestName = "All selected options are New York, Texas, Ohio and California")]
        public void TestFourStatesWithAllSelected(string firstValue, string secondValue, string thirdValue, string fourthValue)
        {
            _page.SelectFromFourValue(firstValue, secondValue, thirdValue, fourthValue)
            .ClickAllSelectedButton();
        }



        

    }
}
