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
        public IWebDriver? driver;

        public bool driverQuit = false;

        public bool headlessTest = false;

    }
}
