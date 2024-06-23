using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using System.Data;
using TestProject1.Utilities;
using TestProject1.Pageobjects;
using AventStack.ExtentReports;

namespace TestProject1.Test
{
    public class Adduserscreen : Base
    {
        

        [Test]


        public void Addusers()
        {


            {




                //Loginpage loginpage = new Loginpage(getDriver());
                // loginpage.ValidLogin("Admin", "admin123");

                //driver.FindElement(By.XPath("//li[1]//a[1]//span[1]")).Click();
                //driver.FindElement(By.CssSelector("button[class='oxd-button oxd-button--medium oxd-button--secondary']")).Click();


                //IWebElement dropdown = driver.FindElement(By.XPath("(//div[@class='oxd-select-text-input'])[1]"));

                //dropdown.Click();

                IList<IWebElement> items = driver.FindElements(By.XPath("//div[@role='listbox']"));

                foreach (IWebElement item in items)
                {
                    if (item.Text.Contains("Admin"))

                        item.Click();

                }

                //driver.FindElement(By.XPath("//input[@placeholder='Type for hints...']")).SendKeys("Joy Smith");

                //IWebElement statusdropdown = driver.FindElement(By.XPath("(//div[@class='oxd-select-text-input'])[2]"));
                //statusdropdown.Click();
                IList<IWebElement> statusitems = driver.FindElements(By.XPath("//div[@role='listbox']"));

                foreach (IWebElement item in statusitems)
                {
                    if (item.Text.Contains("Enabled"))

                        item.Click();

                }

                driver.FindElement(By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]")).SendKeys("joysmithtyuu");
                driver.FindElement(By.XPath("(//input[@class='oxd-input oxd-input--active'])[3]")).SendKeys("joysmithtyuu25");
                driver.FindElement(By.XPath("(//input[@class='oxd-input oxd-input--active'])[4]")).SendKeys("joysmithtyuu25");
                driver.FindElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--secondary orangehrm-left-space']")).Click();

            }
        }
    }
}