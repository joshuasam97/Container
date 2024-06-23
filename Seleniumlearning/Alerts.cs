using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Internal;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Interactions;

namespace Seleniumlearning
{
    public class Alerts
    {
        IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

        }
        [Test]
        public void AlertPractice()
        {
            String name = "Joshua";
            driver.FindElement(By.CssSelector(("#name"))).SendKeys(name);
            driver.FindElement(By.CssSelector("input[onclick*='displayConfirm']")).Click();
            String alerttext = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            //driver.SwitchTo().Alert().Dismiss();
            //driver.SwitchTo().Alert().SendKeys("OK");
            StringAssert.Contains(name, alerttext);


            driver.FindElement(By.Id("autocomplete")).SendKeys("ind");
            Thread.Sleep(3000);
            IList<IWebElement> options = driver.FindElements(By.CssSelector(".ui-menu-item div"));

            foreach (IWebElement option in options)
            {

                if (option.Text.Equals("India"))
                {

                    option.Click();
                }
                TestContext.Progress.WriteLine(driver.FindElement(By.Id("autocomplete")).GetAttribute("value"));
            }






        }

        [Test]
        public void test_advance()
        {
            driver.Url = "https://rahulshettyacademy.com/";
            
            Actions a = new Actions(driver);
            a.MoveToElement(driver.FindElement(By.CssSelector("a[class*='dropdown-toggle']"))).Perform();
            Thread.Sleep(9000);

            a.MoveToElement(driver.FindElement(By.ClassName("dropdown-menu"))).Perform();
            a.MoveToElement(driver.FindElement(By.CssSelector("a[href='about-my-mission']"))).Click().Perform();


        } 

    }
}
       