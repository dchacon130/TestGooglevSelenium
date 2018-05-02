using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestGooglev2.Data;

namespace TestGooglev2
{
    class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        [CacheLookup]
        private IWebElement Reservation { get; set; }

        public void SearchNow(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);
            Reservation.SendKeys(userData.Reservation);
            Reservation.Submit();
        }
    }
}
