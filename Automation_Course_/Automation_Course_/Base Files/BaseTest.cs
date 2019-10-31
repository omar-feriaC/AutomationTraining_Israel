
using Automation_Course_.Reporting;
using Automation_Course_.Utils;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Course_.Base_Files
{
    class BaseTest
    {
        public static ReportManager rm = new ReportManager();
        public static libExcel objxls = new libExcel();
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;
        public static IWebDriver driver;
        private static readonly string BrowserName = ConfigurationManager.AppSettings.Get("url");

        [OneTimeSetUp]
        public static void Setup()
        {
            if (htmlReporter == null)
            {
                htmlReporter = new ExtentHtmlReporter(rm.ReportPath());
            }

            if (extent == null)
            {
                extent = new ExtentReports();
                rm.ReportSetUp(htmlReporter, extent);
            }
        }

        [SetUp]
        public void BeforeTest()
        {
            SetUpDriver();
            objxls.FilePath = @"C:\Tools\DataDriven.xlsx";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            extent.Flush();
        }

        [TearDown]
        public void AfterTest()
        {
            rm.TestCaseResult(test, extent, driver);
            ExitDriver();
        }

        public void SetUpDriver()
        {
            driver = new ChromeDriver();
            driver.Url = BrowserName;
            driver.Manage().Window.Maximize();
        }

        public void ExitDriver()
        {
            driver.Quit();
        }

    }
}
