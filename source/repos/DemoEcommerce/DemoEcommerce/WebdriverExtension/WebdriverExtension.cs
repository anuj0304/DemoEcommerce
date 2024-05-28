using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEcommerce.WebdriverExtension
{
    public static class WebdriverExtension
    {



        public static void EnterText(this IWebDriver driver,By locater,string text)
        {

            IWebElement element = driver.FindElement(locater);
            if(element != null && element.Enabled)
            {
                element.Clear();
                element.SendKeys(text);
            }
        }


        public static void click(this IWebDriver driver , By locater)
        {
            IWebElement element = driver.FindElement(locater);
            if(element.Displayed && element.Enabled)
            {
                element.Click();
            }
        }


        public static bool IsElementDisplayed(this IWebDriver driver, By locater)
        {
            IWebElement element = driver.FindElement(locater);
            if (!element.Displayed)
            {
                return true;
            }

            return true;
        }


        public static string getText(this IWebDriver driver, By locater)
        {

            IWebElement element = driver.FindElement(locater);
            var text= " ";
            if (element != null)
            {
                text = element.Text;

            }
            return text;
        }
    }
}
