using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace Seleniumlearning
{
    public class Dropdown
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

        public void Dropdowns()

        {

            IWebElement Dropdowns = driver.FindElement(By.CssSelector("#dropdown-class-example "));
           SelectElement s = new SelectElement(Dropdowns);
            s.SelectByText("Option1");

           //IList <IWebElement> rdos = driver.FindElements(By.CssSelector("input[name='radioButton']"));

           // rdos[2].Click();

           // Boolean result = driver.FindElement(By.CssSelector("input[name='radioButton']")).Selected;
           // Assert.That(result, Is.False);
        }

    }
}

    
