using Automation_Course_.Base_Files;
using Automation_Course_.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Course_.Test_Cases
{
    class NewTour_LoginTest : BaseTest
    {
        NewTour_LoginPage LoginPage;

        /*Method for running flow in web application*/
        [Test]
        public void RunLogin()
        {
            LoginPage = new NewTour_LoginPage(driver);
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            LoginPage.EnterUserNameTxtField(ConfigurationManager.AppSettings.Get("user"));
            LoginPage.EnterPasswordTxtField(ConfigurationManager.AppSettings.Get("password"));
            LoginPage.ClickSignInButton();
        }

        [Test]
        public void RegisterLink()
        {
            LoginPage = new NewTour_LoginPage(driver);
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Utils.libUtils.AssertEqualString("REGISTER", LoginPage.GetRegisterLink().Text);
            Utils.libUtils.AssertIsPresent(LoginPage.GetSignInButton());
        }

        [Test]
        public void RunDataDriver()
        {
            LoginPage = new NewTour_LoginPage(driver);
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            LoginPage.EnterUserNameTxtField(objxls.ReadExcelByIndex("Data1", "UserName", "2"));
            LoginPage.EnterPasswordTxtField(objxls.ReadExcelByIndex("Data1", "Password", "2"));
            LoginPage.ClickSignInButton();
        }

    }
}
