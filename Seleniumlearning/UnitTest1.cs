using NUnit.Framework;

namespace Seleniumlearning;

public class Tests
{
    [SetUp]
    public void Setup()
    {

        TestContext.Progress.WriteLine("Setup the page");
    }


    [Test]
    public void Test1()
    {
        TestContext.Progress.WriteLine("Test the page");
    }
}