using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEcommerce.Pages
{
    public class HomePage
    {
        public static IWebDriver driver;
        //Create constructor 

        public HomePage(IWebDriver driver)
        {

            HomePage.driver = driver;

           
        }


        //Page objects for WebElements
       public static readonly By RegisterLink = By.XPath("//a[contains(text(),'Register')]");
       public static readonly By LoginLink = By.XPath("//a[contains(text(),'Log in')]");


        public string GetTitle()
        {
            return driver.Title;
        }

        public void ClickRegisterPage()
        {
            driver.FindElement(RegisterLink).Click();
        }

        public void ClickLoginPage()
        {

            driver.FindElement(LoginLink).Click();
        }
           
        

    }
}
