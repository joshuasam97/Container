using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pageobjects
{
    public class Searchusertc
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Searchusertc(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//li[1]//a[1]//span[1]")]
        private IWebElement Admintabclick;

        [FindsBy(How = How.CssSelector, Using = "div[class='oxd-input-group oxd-input-field-bottom-space'] div input[class='oxd-input oxd-input--active']")]
        private IWebElement Searchtextbox;


        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement Searchbutton;

        public IWebElement clickAdmintab()
        {
            return Admintabclick;

        }

        public IWebElement searchtextboxinput()
        {
            return Searchtextbox;

        }

        public IWebElement searchbuttonclick()
        {
            return Searchbutton;

        }
        public void ValidSearch(string name)
        {

            Admintabclick.Click();
            Searchtextbox.SendKeys(name);
            Searchbutton.Click();


        }
        public void waitforfilterresult()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='oxd-text oxd-text--span']")));
        }


    }


    //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='oxd-text oxd-text--span']")));


}

