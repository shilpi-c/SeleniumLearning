﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.PageObjects
{
    public class CustomerManagementPage
    {
        IWebDriver driver;
        public CustomerManagementPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement addButton => driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement specificCustomerCheckbox => driver.FindElement(By.XPath("//td[text()='Ankit']//preceding-sibling::td//input"));
        public IWebElement deleteCustomerButton => driver.FindElement(By.Id("deleteAll"));
    }
}
