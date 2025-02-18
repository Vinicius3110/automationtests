using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Core
{
    public class GlobalVariables
    {
        public IWebDriver? Driver { get; set; }

        public WebDriverWait? Wait { get; set; }

        public bool driverQuit = false;

        public bool headlessTest = false;
    }
}
