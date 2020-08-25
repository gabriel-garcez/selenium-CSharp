using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace vaidarerrado
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("http://www.amazon.com.br");

        }

        [Test]
        public void Test1()
        {
            //driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Test");
            driver.FindElement(By.XPath("//input[@id='twotabsearchtextbox']")).SendKeys("Test");
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}