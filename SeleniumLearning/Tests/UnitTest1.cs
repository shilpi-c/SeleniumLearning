using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumLearning
{
   
    public class Tests
    {

        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.actitime.com/login.do");
          
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("username")).SendKeys("admin");
            driver.FindElement(By.Name("pwd")).SendKeys("manager");

        }
        [Test]
        public void Test2()
        { 
        driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("admin");
        }
        [OneTimeTearDown]
        public void Close()
        { 
            driver.Close();
        }
    }
}