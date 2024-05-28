using AventStack.ExtentReports;
using DemoEcommerce.BasePage;
using DemoEcommerce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEcommerce.Tests
{

    [TestFixture]
    public class RegisterTest : BaseClass
    {
        public HomePage home;
        public RegisterPage register;
       

        [Test]
        public void VerifyRegisterFunctionality()
        {
            home = new HomePage(driver);
            register = new RegisterPage(driver);

            Assert.AreEqual(home.GetTitle(), "Demo Web Shop");
            home.ClickRegisterPage();
            register.SelectGender();
            register.EnterFirstName("Anuj");
            register.EnterLastName("QAT");
            register.EnterEmail();
            register.Enterpaswword("Test@123");
            register.EnterConfirmPassword("Test@123");

            register.ClickRegisterButton();
          string result = register.GetSuccessMessage();

            Assert.AreEqual(result, "Your registration completed");

            bool emaildisplayed = register.isEmailAccountDisplayed();

            Assert.IsTrue(emaildisplayed);


            register.logout();

        }

    }
}
