using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Pageobjects;
using TestProject1.Utilities;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1.Test
{
    public class Edituser : Base
    {
        IWebDriver driver;
        

        [Test]

        public void Edituserbutton()
        {
            Loginpage loginpage = new Loginpage(getDriver());
            loginpage.ValidLogin("Admin", "admin123");
            Searchusertc searchuser = new Searchusertc(getDriver());
            searchuser.ValidSearch("Admin");
            // driver.FindElement(By.CssSelector(".oxd-icon.bi-pencil-fill")).Click();
            EditUsertc editbutton = new EditUsertc(getDriver());
            editbutton.EditButton();
            EditUsertc statusclick = new EditUsertc(getDriver());
            statusclick.Statusdropdownclick();
            IList<IWebElement> statusitems = driver.FindElements(By.XPath("//div[@role='listbox']"));

            foreach (IWebElement item in statusitems)
            {
                if (item.Text.Contains("Disabled"))

                    item.Click();

            }










        }

    }
}


