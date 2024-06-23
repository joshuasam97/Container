using NUnit.Framework;
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
    public class Seleniumfirsttest
    {

        IWebDriver driver;
        
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://rahulshettyacademy.com/locatorspractice/";

        }

        [Test]
        public void Locators() 
        {
            driver.FindElement(By.Id("inputUsername")).SendKeys("Joshuasamuel");
            driver.FindElement(By.Name("inputPassword")).SendKeys("llll");
            driver.FindElement(By.XPath("//div[@class='checkbox-container']/span/input")).Click();
            driver.FindElement(By.CssSelector("button[type='Submit']")).Click();
            //driver.FindElement(By.XPath("//button[@type='Submit']")).Click();

    
           String errorname = driver.FindElement(By.ClassName("error")).Text;
            TestContext.Progress.WriteLine(errorname);

           // IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
          // String linkattr = link.GetAttribute("href");
            //String expectedurl = "https://rahulshettyacademy.com/documents-request";
           // Assert.AreEqual(expectedurl, linkattr); //Validate the link

        }



    }
}
