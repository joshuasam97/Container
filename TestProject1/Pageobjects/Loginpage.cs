using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Test;

namespace TestProject1.Pageobjects
{
    public class Loginpage
    {
        private IWebDriver driver;
      public  Loginpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Username']")]
        private IWebElement Username;

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Password']")]
        private IWebElement Password;

        [FindsBy(How = How.TagName, Using = "button")]
        private IWebElement Loginbutton;

        // [FindsBy(How = How.TagName, Using = "h6")]
        // private IWebElement OptionOnPage;

        public void ValidLogin (string User, string Pass)
        {

            Username.SendKeys(User); 
            Password.SendKeys(Pass);
            Loginbutton.Click();
            
            

        }



        public IWebElement getUsername()
        {
            return Username;

        }
             

    }
}

