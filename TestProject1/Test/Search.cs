using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using TestProject1.Pageobjects;
using TestProject1.Utilities;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1.Test
{
    public class Search : Base
    {
        IWebDriver driver;



        [Test]

        public void Searchuser()
        {

            Loginpage loginpage = new Loginpage(getDriver());
            loginpage.ValidLogin("Admin", "admin123");
            UserManagementPage us = new UserManagementPage(getDriver());
            us.userNameSearch("Admin");
            bool filterresults = us.filterresults.Displayed;
            TestContext.WriteLine("Admin " + filterresults);
            Assert.That(filterresults, Is.True, "Admin");



            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//span[@class= 'oxd-text oxd-text--span'])[1]")));







            // //driver.FindElement(By.CssSelector("input[placeholder='Username']")).SendKeys("Admin");
            // //driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("admin123");
            // //driver.FindElement(By.TagName("button")).Click();
            // //driver.FindElement(By.XPath("//li[1]//a[1]//span[1]")).Click();
            // //driver.FindElement(By.CssSelector("div[class='oxd-input-group oxd-input-field-bottom-space'] div input[class='oxd-input oxd-input--active']")).SendKeys("Admin");
            // //driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            // //bool display = driver.FindElement(By.("(//div[contains(text(),'Admin')])[1]")).Displayed;
            // //TestContext.Progress.WriteLine(display);
            // //if (display)
            // //{
            // //    TestContext.Progress.WriteLine("Searched value is there");

            // //}

            // //else
            // //{
            // //    TestContext.Progress.WriteLine("Searched value is not there");
            // //}







        }

    }
}
