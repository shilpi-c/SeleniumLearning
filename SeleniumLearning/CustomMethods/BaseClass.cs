using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.CustomMethods
{
    public static class BaseClass
    {
        public static IWebDriver MyDriver { get; set; }

        // custom method for entering a text in to a field
        public static void EnterText(this IWebElement element, string value)
        {
            element.Click();
            element.Clear();
            element.SendKeys(value);
        }

        public static void EnterDropDownText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // Custom Method for Selecting from a dropdown. we can specifty select type as Text, Value or Index
        public static void SelectFromDropDownByText(IWebElement element, string inputText)
        {
            //new SelectElement(element).SelectByText(inputValue);
            SelectElement se = new SelectElement(element);
            se.SelectByText(inputText);
        }
        public static void SelectFromDropDownByValue(IWebElement element, string inputValue)
        {
            //new SelectElement(element).SelectByValue(inputValue);
            SelectElement se = new SelectElement(element);
            se.SelectByValue(inputValue);
        }
        public static void SelectFromDropDownByIndex(IWebElement element, int index)
        {
            //new SelectElement(element).SelectByValue(inputValue);
            SelectElement se = new SelectElement(element);
            se.SelectByIndex(index);
        }

        // Custom Method for Drag and drop. we need to specify the origin element and destination elements
        public static void DragAndDropItem(IWebElement sourceElement, IWebElement destinationElement)
        {
            Actions action = new Actions(MyDriver);
            action.ClickAndHold(sourceElement).MoveToElement(destinationElement).Release().Build().Perform();
        }

    }
}
