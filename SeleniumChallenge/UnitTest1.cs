using OpenQA.Selenium;
using Xunit;


namespace SeleniumChallenge
{
    [Collection("Selenium Tests")]
    public class UnitTest1
    {
        private readonly IWebDriver _driver;

        public UnitTest1(SeleniumFixture fixture)
        {
            _driver = fixture.WebDriver;
        }

        [Fact]
        public void SendTemplateMessage()
        {
            
        }
    }
}