using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TestGooglev2.TestCase;
using OpenQA.Selenium.PhantomJS;

namespace TestGooglev2
{
    /// <summary>
    /// Summary description for LoadTest
    /// </summary>
    [TestClass]
    public class LoadTest
    {
        private IWebDriver driver;
        public LoadTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        #endregion
        // Use TestInitialize to run code before running each test 
        [TestInitialize]
        public void MyTestInitialize()
        {
            /*EJECUTAR DESDE FIREFOX*/
            this.driver = new FirefoxDriver();
            /*EJECUTAR DESDE PHANTOMJSDRIVER*/
            //this.driver = new PhantomJSDriver();
            //this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TestMethod]
        public void TestMethod1()
        {   
            /*OPEN BROWSER AND GOOGLE.COM*/
            var openWeb = new OpenWeb(this.driver);
            openWeb.open();
            /*SELECT IMPUT AND SEARCH*/
            var sPage = new SearchPage(this.driver);
            sPage.SearchNow("LoadTest");
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
    }
}
