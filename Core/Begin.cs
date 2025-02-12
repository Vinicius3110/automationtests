using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography.X509Certificates;

namespace TestProject.Core
{
    public class Begin : DSL
    {
        #region Definitions
        private void AbreNavegador()
        {
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size=1920,1080");
            headlessMode.AddArgument("disk-cache-size=0");
            headlessMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0");
            devMode.AddArgument("start-maximized");

            if (headlessTest) 
            {
                driver = new ChromeDriver(headlessMode);
            }
            else
            {
                driver = new ChromeDriver(devMode);
                driverQuit = false;
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        #endregion

        #region SetUp
        [SetUp]
        public void Setup()
        {
            AbreNavegador();
            driver.Navigate().GoToUrl("https://saph-dev.rs.true.com.br//login");
            IWebElement webElement = driver.FindElement(By.XPath("/html/body/app-root/app-login/div/div/div/div/div/div/button"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            webElement.Click();
        }
        #endregion

        #region TearDown
        [TearDown]
        public void ResultadoFimDoTeste()
        {
            if (driverQuit) driver.Quit();

        }
        #endregion
    }
}   
         

