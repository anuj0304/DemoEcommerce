using AventStack.ExtentReports;
using DemoEcommerce.Utilities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEcommerce.BasePage
{
    public class BaseClass
    {
        private ExtentReports _extent;
        private ExtentTest _test;

        public static IWebDriver driver;

        [SetUp]
        public void setUp()
        {
           
              driver = new ChromeDriver();
        
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
            _extent = ExtentReportManager.GetExtentReports();
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);

        }


        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                Screenshot screenshot = ts.GetScreenshot();


                string testName = TestContext.CurrentContext.Test.Name;
                string fileName = $"C:\\Users\\Dell\\source\\repos\\DemoEcommerce\\DemoEcommerce\\Screenshots\\{testName}.png";
                screenshot.SaveAsFile(fileName);
            }
 
            driver.Quit();
            driver.Dispose();
            _extent.Flush();
           
        }

    }
}
