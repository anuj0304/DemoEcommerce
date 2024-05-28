using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEcommerce.Utilities
{
    public  class ExtentReportManager
    {
        private static ExtentReports extent;
        private static ExtentSparkReporter htmlreporter;



        public static ExtentReports GetExtentReports()
        {
            if (extent == null)
            {
                extent = new ExtentReports();

                htmlreporter = new ExtentSparkReporter("testreport.html");
                extent.AttachReporter(htmlreporter);
            }


            return extent;
        }
        
    }
}
