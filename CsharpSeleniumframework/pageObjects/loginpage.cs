using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSeleniumframework.pageObjects
{
    public class loginPage
    {
        private IWebDriver driver;
        public loginPage(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;//cant access this directly so you need one method

        public IWebElement getUsername()
            {

            return username;    
            }
    }
}
