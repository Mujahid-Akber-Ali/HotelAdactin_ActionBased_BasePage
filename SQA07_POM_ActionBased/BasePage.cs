using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;

namespace SQA07_POM_ActionBased
{    
    public class BasePage
    {
        public static IWebDriver driver;

        public void SeleniumInitialization(string browser)
        {
            driver = new EdgeDriver();
        }

        public void SeleniumClose()
        {
            driver.Close();
        }


        public void Write(By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
        }

        public void Click(By by)
        {
            driver.FindElement(by).Click();
        }

        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
    }
}
