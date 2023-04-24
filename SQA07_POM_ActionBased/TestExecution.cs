using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SQA07_POM_ActionBased
{
    [TestClass]
    public class TestExecution
    {
        BasePage BasePage = new BasePage();

        [TestInitialize]
        public void TestInit()
        {
            BasePage.SeleniumInitialization("Edge");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.SeleniumClose();
        }

        [TestMethod]
        public void LoginTC()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Login("https://adactinhotelapp.com/", "AmirImam","AmirImam");  
        }

        [TestMethod]
        public void SearchTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            SearchPage searchPage = new SearchPage();
            #endregion

            #region Scenario/Steps

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.Search("Sydney");

            #endregion
        }

        [TestMethod]
        public void SelectTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            SearchPage searchPage = new SearchPage();
            SelectPage selectPage = new SelectPage();    
            #endregion

            #region Scenario/Steps

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.Search("Sydney");
            selectPage.Select();

            #endregion
        }
    }
}
