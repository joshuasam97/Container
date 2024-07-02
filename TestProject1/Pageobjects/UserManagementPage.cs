using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using AventStack.ExtentReports;

namespace TestProject1.Pageobjects
{
    public class UserManagementPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public UserManagementPage(IWebDriver driver)

        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//div[text() = 'Admin'])[1]")]
        public IWebElement filterresults;
        [FindsBy(How = How.XPath, Using = "//i[@class='oxd-icon bi-pencil-fill']")]
        IWebElement edituser;
        //[FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text-input'])[2]")]


        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text oxd-select-text--active'])[2]")]

        private IWebElement changestatus;
        //[FindsBy(How = How.XPath, Using = "//div[text()='Disabled']")]
        //private IWebElement disabled;

        public void userNameSearch(string us)
        {
            admintab.Click();
            userSearch.SendKeys(us);
            searchButton.Click();


        }


        public IWebElement getEdituser()
        {
            return edituser;
        }




        //public void Statusdropdown()
        //{
        //    SelectElement s = new SelectElement(changestatus);
        //    s.SelectByText("Disabled");
        //}

        //public IWebElement getStatusdropdown()
        //{
        //    wait.Until(ExpectedConditions.ElementToBeClickable(changestatus));
        //    return changestatus;

        //}





        //}

        //public void Statusdropdown(string option)
        //{
        //    Status.Click();

        //    IList<IWebElement> lists = driver.FindElements(By.XPath("//div[@role='listbox']"));
        //    foreach (IWebElement list in lists)
        //    {
        //        if (list.Text.Contains(option))
        //        {
        //            list.Click();
        //            // Status.SendKeys(Keys.Escape);
        //            break;
        //        }
        //    }


            //}
        }
}
