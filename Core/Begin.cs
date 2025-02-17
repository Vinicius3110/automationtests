using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Core
{
    public class Begin
    {

        protected GlobalVariables globalVariables { get; private set; }
        protected DSL dsl { get; private set; }

        public Begin()
    {
        globalVariables = new GlobalVariables();
        dsl = new DSL();
    }

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

            if (globalVariables.headlessTest) 
            {
                globalVariables.Driver = new ChromeDriver(headlessMode);
            }
            else
            {
                globalVariables.Driver = new ChromeDriver(devMode);
                globalVariables.driverQuit = false;
            }
            globalVariables.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        #endregion

        #region SetUp
        [SetUp]
        public void Setup()
        {
            AbreNavegador();
            globalVariables.Driver.Navigate().GoToUrl("https://saph-dev.rs.true.com.br//login");
            IWebElement webElement = globalVariables.Driver.FindElement(By.XPath("/html/body/app-root/app-login/div/div/div/div/div/div/button"));
            globalVariables.Wait.Until(driver => webElement.Displayed && webElement.Enabled);
            webElement.Click();
        }
        #endregion

        #region TearDown
        [TearDown]
        public void ResultadoFimDoTeste()
        {
            if (globalVariables.driverQuit) globalVariables.Driver.Quit();

        }
        #endregion
    }
}   
         

