using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

namespace TestGooglev2.TestCase
{
    class OpenWeb
    {
        private IWebDriver driver;
        private string url = ConfigurationManager.AppSettings["URL"];

        public OpenWeb(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }
        public void open()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }
    }
}
