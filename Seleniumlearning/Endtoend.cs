using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace Seleniumlearning
{
    public class Endtoend
    {
        IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

        }
        [Test]
        public void Endtotest()


        {
            String[] expectedproducts = { "iphone X", "Blackberry" };
            String[] actualproducts = new string[2]; 
                
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Name("password")).SendKeys("learning");
            driver.FindElement(By.ClassName("checkmark")).Click();
           driver.FindElement(By.CssSelector("input[type='Submit']")).Click();
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));

            IList<IWebElement> products = driver.FindElements(By.TagName("app-card"));
            foreach (IWebElement product in products)
            {

                if (expectedproducts.Contains(product.FindElement(By.CssSelector(".card-title a")).Text))

                {
                   product.FindElement(By.CssSelector(".card-footer button")).Click() ;
                      
                }


                TestContext.Progress.WriteLine(product.FindElement(By.CssSelector(".card-title a")).Text);

                
            }

            driver.FindElement(By.PartialLinkText("Checkout ")).Click();

            IList <IWebElement> checkoutcards = driver.FindElements(By.CssSelector("h4 a"));

            for (int i = 0; i < checkoutcards.Count; i++) 
            {
                actualproducts[i] = checkoutcards[i].Text;

            }

            Assert.AreEqual(expectedproducts, actualproducts);

            driver.FindElement(By.CssSelector(".btn.btn-success")).Click();
            driver.FindElement(By.Id("country")).SendKeys("ind");
            Thread.Sleep(9000);
           
            driver.FindElement(By.XPath("//ul/li[a='India']/a")).Click();
            driver.FindElement(By.CssSelector("label[for*='checkbox2']")).Click();
            driver.FindElement(By.CssSelector(".btn-lg")).Click();
        }

    }
}
