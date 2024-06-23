using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Seleniumlearning
{
    public class Scrollingactionjs
    {


        IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

        }

        [Test]
        public void Toscrollandsee()
        {
            IWebElement scrolling = driver.FindElement(By.CssSelector("#mousehover"));
        
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("arguments[0].scrollIntoView(true);", scrolling);
            driver.FindElement(By.CssSelector("#mousehover")).Click();
        }

    }

}
