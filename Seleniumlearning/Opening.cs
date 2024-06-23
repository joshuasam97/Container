using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Seleniumlearning
{
    public class Opening
    {

        IWebDriver driver;
        [SetUp]

        public void Starting()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.flipkart.com/";

        }
        [Test]
        public void Flipkartpage()


        {
            driver.FindElement(By.ClassName("_1TOQfO")).Click();
            driver.FindElement(By.XPath("//input[@class='_18u87m_3WuvDp']")).SendKeys("9789968918");

        }
    }
}