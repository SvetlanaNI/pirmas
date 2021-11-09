using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas.Test
{
    public class VartuTechnikaTest
    {
        private static IWebDriver _driver;

         [OneTimeSetUp]
         public static void SetUp()
        {
            _driver = new ChromeDriver();
        }

    }
}
