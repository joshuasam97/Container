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
            HomePage hm = new HomePage(getDriver());
            hm.getAdminTab().Click();
            UserManagementPage us = new UserManagementPage(getDriver());
            us.userNameSearch("Admin");
            us.getEdituser().Click();
            us.getStatusdropdown().Click();














            //    Searchusertc searchuser = new Searchusertc(getDriver());
            //    searchuser.ValidSearch("Admin");
            //    driver.FindElement(By.CssSelector(".oxd-icon.bi-pencil-fill")).Click();
            //    UserManagementPage editbutton = new UserManagementPage(getDriver());
            //    editbutton.EditButton();
            //    UserManagementPage statusclick = new UserManagementPage(getDriver());
            //    statusclick.Statusdropdownclick();
            //    IList<IWebElement> statusitems = driver.FindElements(By.XPath("//div[@role='listbox']"));

            //    foreach (IWebElement item in statusitems)
            //    {
            //        if (item.Text.Contains("Disabled"))

            //            item.Click();

            //    }



            //}
        }
    }
}











