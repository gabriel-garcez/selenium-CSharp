using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumFramework.PageObject;


namespace SeleniumFramework
{
    class LogInTest
    {
        [Test]
        public void Test()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.store.demoqa.com";

            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.MyAccount.Click();


            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("TestUser_1");
            loginPage.Password.SendKeys("Test@123");
            loginPage.Submit.Submit();

        }
    }

}