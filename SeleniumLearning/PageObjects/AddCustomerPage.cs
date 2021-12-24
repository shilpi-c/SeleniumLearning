using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.PageObjects
{
    public class AddCustomerPage
    {
        IWebDriver driver;
        public AddCustomerPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement addButton => driver.FindElement(By.XPath("//button[@type='submit']"));

    }
}
