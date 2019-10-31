using Automation_Course_.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Course_.Page_Objects
{
    class NewTour_LoginPage : BaseTest
    {
        /*LOCATORS FRO EACH AND EVERY ELEMENT IN PAGE*/
        private static readonly string USERNAME_TEXTFIELD = "userName";
        private static readonly string PASSWORD_TEXTFIELD = "password";
        private static readonly string SINGIN_BUTTON = "//input[@name='login']";
        private static readonly string REGISTER_LINK = "//a[contains(text(), 'Register')]";

        /*DRIVER REFERENCE FOR THIS PARTICULAR POM*/
        private IWebDriver _driver;

        /*POM FILE CONSTRUCTOR BY TAKING AS PARAMETER "DRIVER" FROM BASETEST CLASS*/
        public NewTour_LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        /*LOCATORS VALUES STORED AS IWebElement OBJECTS TO BE USED IN FRAMEWORK THROUGH METHODS FROM THIS POM CLASS*/
        /*SET*/
        private IWebElement UserNameTxtField => _driver.FindElement(By.Name(USERNAME_TEXTFIELD));
        private IWebElement PasswordTxtField => _driver.FindElement(By.Name(PASSWORD_TEXTFIELD));
        private IWebElement SignIngBtn => _driver.FindElement(By.XPath(SINGIN_BUTTON));
        private IWebElement RegisterLink => _driver.FindElement(By.XPath(REGISTER_LINK));

        /*METHODS FOR ACCESING TO WEBELEMENTS FROM THIS PARTICULAR POM CLASS*/

        //USER NAME FIELDS
        public IWebElement GetUserNameTxtField()
        {
            return UserNameTxtField;
        }

        public void EnterUserNameTxtField(string strUserName)
        {
            UserNameTxtField.Clear();
            UserNameTxtField.SendKeys(strUserName);
        }

        //PASSWORD FIELDS
        public IWebElement GetPasswordTxtField()
        {
            return PasswordTxtField;
        }

        public void EnterPasswordTxtField(string strPassword)
        {
            PasswordTxtField.Clear();
            PasswordTxtField.SendKeys(strPassword);
        }

        //SignIn BUTTTON
        public IWebElement GetSignInButton()
        {
            return SignIngBtn;
        }

        public void ClickSignInButton()
        {
            SignIngBtn.Click();
        }


        //REGISTER LINK
        public IWebElement GetRegisterLink()
        {
            return RegisterLink;
        }

        public void ClickRegisterLink()
        {
            RegisterLink.Click();
        }
    }
}
