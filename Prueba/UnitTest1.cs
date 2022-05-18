using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Prueba
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Url = "https://siap.golmex.mx/GMX/Cuenta/Login";
        }

        [Test]
        public void Test1()
        {
            _driver.FindElement(By.Id("Usuario")).SendKeys("PRUEBA .NET");
            _driver.FindElement(By.Id("Contrase_a")).SendKeys("123456");
            _driver.FindElement(By.CssSelector("login-button")).SendKeys("123456");
        }

        [TearDown]
        public void ClearUp() {
            _driver.Quit();
        }
    }
}