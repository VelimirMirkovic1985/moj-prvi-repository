using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace Cas_28_vezba_domaci
{
    class Test28
    {

        IWebDriver driver;

        [Test]
        public void Search()
        {

            IWebElement inputSearch = driver.FindElement(By.Name("search_query"));
            if (inputSearch.Displayed && inputSearch.Enabled)
            {
                inputSearch.SendKeys("faded");
                Assert.Pass();
            }

            IWebElement FFS_T_Shirts = driver.FindElement(By.LinkText("Fadad Short Sleeve T-shirts"));
            if (FFS_T_Shirts.Displayed && FFS_T_Shirts.Enabled)
            {
                FFS_T_Shirts.Click();
            }

            IWebElement input_Quantity = driver.FindElement(By.Name("qty"));
            if (input_Quantity.Displayed && input_Quantity.Enabled)
            {
                input_Quantity.SendKeys("2");
                Assert.Pass();
            }

            IWebElement Size = driver.FindElement(By.Name("group_1"));
            if (Size.Enabled) Size.SendKeys("L");

            IWebElement add_button = driver.FindElement(By.Name("Submit"));
            if (add_button.Enabled) add_button.Click();

            IWebElement Continue_shopping = driver.FindElement(By.ClassName("button-exclusive btn btn-default"));
            if (Continue_shopping.Displayed) Continue_shopping.Click();
        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
