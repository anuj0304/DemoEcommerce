using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DemoEcommerce.WebdriverExtension;
using Bogus;

namespace DemoEcommerce.Pages
{
    public class RegisterPage 
    {
        public static IWebDriver driver;

        //Create constructor 

        public RegisterPage(IWebDriver driver)
        {

            RegisterPage.driver = driver;
        }


        //input[@value="M"]
        private static readonly By gendorMale = By.Id("gender-male");
        private static readonly By FirstName = By.Id("FirstName");
        private static readonly By LastName = By.Id("LastName");
        private static readonly By Email = By.Id("Email");
        private static readonly By Password = By.Id("Password");
        private static readonly By ConfirmPassword = By.Id("ConfirmPassword");
        private static readonly By RegisterButton = By.Id("register-button");
        private static readonly By LogoutButton = By.LinkText("Log out");

        private static readonly By Result = By.ClassName("result");

        Faker faker;

        string emaildata = "anujnagaich8@gmail.com";



        public string GetTitle()
        {
            return driver.Title;
        } 

        public void SelectGender()
        {
            driver.click(gendorMale);

        }


        public void EnterFirstName(string value)
        {

            driver.EnterText(FirstName, value);
        }


        public void EnterLastName(string value)
        {

            
            driver.EnterText(LastName, value);

        }


        public void EnterEmail()
        {

            driver.EnterText(Email, emaildata);
        }

        public void Enterpaswword(string value)
        {

            driver.EnterText(Password, value);
        }


        public void EnterConfirmPassword(string value)
        {

            driver.EnterText(ConfirmPassword, value);
        }

        public void ClickRegisterButton()
        {
            driver.click(RegisterButton);
        }

        public string GetSuccessMessage()
        {
          return  driver.getText(Result);
        }

        public bool isEmailAccountDisplayed()
        {
          return  driver.FindElement(By.XPath("//*[text()='"+ emaildata + "']")).Displayed;

            
        }

         public void logout()
        {
            driver.click(LogoutButton);
        }

    }
}
