using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace SeleniumChallenge
{
    public class SeleniumFixture : IDisposable
    {
        public IWebDriver WebDriver;

        public SeleniumFixture()
        {
            WebDriver = new ChromeDriver(Directory.GetCurrentDirectory());

            WebDriver.Navigate().GoToUrl("[URL]");
            var username = WebDriver.FindElement(By.Id("username"));
            var btnNext = WebDriver.FindElement(By.Id("next"));
            username.SendKeys("[USERNAME]");
            btnNext.Click();

            var password = WebDriver.FindElement(By.Id("password"));
            var btnLogin = WebDriver.FindElement(By.Id("login"));

            password.SendKeys("[PASSWORD]");
            btnLogin.Click();

        }

        public void Dispose()
        {
            WebDriver.Quit();
        }
    }

    [CollectionDefinition("Selenium Tests")]
    public class SeleniumCollection : ICollectionFixture<SeleniumFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
    
