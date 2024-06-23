using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Interfaces;
using System.Diagnostics;
using System.IO;


namespace TestProject1.Utilities
{
    public class Base

    {

        //string browserName;
        public IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {
            String browserName = ConfigurationManager.AppSettings["browser"];

            InitBrowser(browserName);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        }



        public IWebDriver getDriver()
        {
            return driver;
        }


        public void InitBrowser(String broswerName)
        {
            switch (broswerName)
            {
                case "Chrome":

                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Edge":

                    driver = new EdgeDriver();
                    break;


            }

        }

        //[TearDown]
        //public void cometoend()
        //{


        //    driver.Quit();
        //}
    }
}
    

    

