using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pageobjects
{

    public class DeleteUser
    {
        private IWebDriver driver;
        public DeleteUser(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//i[@class='oxd-icon bi-check oxd-checkbox-input-icon'])[2]")]
        private IWebElement checkbox;
       // (//span[@class=\"oxd-checkbox-input oxd-checkbox-input--active --label-right oxd-checkbox-input\"])[2]
        //[FindsBy(How = How.XPath, Using = "(//div[@class='oxd-table-cell oxd-padding-cell'])[8]")]
        //private IWebElement deleteUser;
        // [FindsBy(How = How.XPath, Using = "(//button[@type='button'])[7]")]
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'cell-actions')]/button[@type='button'])[3]")]
        private IWebElement deleteUser;
      

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'footer')]/button/i[contains(@class,'trash')]")]
        private IWebElement confirmdeleteUser;
        [FindsBy(How = How.XPath, Using = "//div[text()='']")]
        public IWebElement validateUser;



        public void UserDelete(string username)
        {
            admintab.Click();
            userSearch.SendKeys(username);
            searchButton.Click();
            checkbox.Click();
            deleteUser.Click();
            confirmdeleteUser.Click();
        }

    }


}
