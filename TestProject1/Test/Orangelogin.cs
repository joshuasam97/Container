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
    public class Orangelogin : Base
    { 

     [Test]

    public void Login()
    {
          Loginpage loginpage = new Loginpage(getDriver());
            loginpage.ValidLogin("Admin", "admin123");

            //driver.FindElement(By.CssSelector("input[placeholder='Username']")).SendKeys("Admin");
           // driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("admin123");
        //driver.FindElement(By.TagName("button")).Click();
        //String logincheck = driver.FindElement(By.TagName("h6")).Text;
        //TestContext.Progress.WriteLine(logincheck);



        }

}
}
