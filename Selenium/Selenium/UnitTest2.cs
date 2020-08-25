using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace vaidarerrado
{
    public class Tests2
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("http://www.google.com.br");

        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Name("q")).SendKeys("Test");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}