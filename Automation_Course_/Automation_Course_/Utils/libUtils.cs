using Automation_Course_.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Course_.Utils
{
    class libUtils : BaseTest
    {
        public static void AssertEqualString(string strExpectedResult, string strActualResult)
        {
            Assert.AreEqual(strExpectedResult, strExpectedResult);
        }

        public static void AssertIsPresent(IWebElement boolElement)
        {
            Assert.IsTrue(boolElement.Displayed);
        }
    }
}
