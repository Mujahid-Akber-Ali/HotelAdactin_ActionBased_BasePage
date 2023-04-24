using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Web;

namespace SQA07_POM_ActionBased
{    
    public class LoginPage : BasePage
    {
        #region LOCATORS
        By usernameTXT = By.Id("username");
        By passwordTXT = By.Name("password");
        By LoginBTN = By.Id("login");
        #endregion

        public void Login(string url, string user, string pass)
        {
            driver.Url = url;
            Write(usernameTXT, user);
            Write(passwordTXT, pass);
            Click(LoginBTN);
        }

        public void Login(string user, string pass)
        {
            Write(usernameTXT, user);
            Write(passwordTXT, pass);
            Click(LoginBTN);
        }
    }
}
