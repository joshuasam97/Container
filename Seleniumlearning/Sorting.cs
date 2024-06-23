using AngleSharp.Dom;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Seleniumlearning
{
    public class Sorting
    {
        IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";

        }
        [Test]
        public void Sortings()



        {
            ArrayList a = new ArrayList();
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("page-menu")));

            dropdown.SelectByValue("20");

            IList <IWebElement> veggies = driver.FindElements(By.XPath("//tr/td[1]"));


            foreach (IWebElement veggie in veggies)
            {
                  a.Add(veggie.Text);    

            }

            foreach (String Element in a)
            {
                TestContext.Progress.WriteLine(Element);
            }
            TestContext.Progress.WriteLine("Aftersort");
            a.Sort();

            foreach (String Element in a)
            {
                TestContext.Progress.WriteLine(Element);
            }

            driver.FindElement(By.CssSelector("th[aria-label*='fruit name']")).Click();

            ArrayList b = new ArrayList();

            IList<IWebElement> sortedveggies = driver.FindElements(By.XPath("//tr/td[1]"));


            foreach (IWebElement veggie in sortedveggies)
            {
                b.Add(veggie.Text);

           }
            Assert.That(b, Is.EqualTo(a));

        }


    }
}
