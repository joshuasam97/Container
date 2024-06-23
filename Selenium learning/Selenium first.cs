using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace Selenium_learning
public class Seleniumfirst
{

    IWebDriver driver;


    [SetUp]
    public void StartBrowser()
    {

        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

         driver = new ChromeDriver();

    }

    [Test]
    public void Test1()
    {

        driver.Url = "";
    }
}
}