using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace TestProject1.Pageobjects
{
    public class EditUsertc
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public EditUsertc(IWebDriver driver)

        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".oxd-icon.bi-pencil-fill")]
        private IWebElement Editclick;

        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text oxd-select-text--active'])[2]")]
        private IWebElement Statusdropdown;


        public IWebElement clickeditbutton()

        {

            return Editclick;
        }

        public void EditButton()
        {

            Editclick.Click();

        }
        public void Statusdropdownclick()
        {

            Statusdropdown.Click();
        }



    }
}
