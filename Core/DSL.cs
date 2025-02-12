using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject.Core
{
    public class DSL : GlobalVariables 
    {
        public void EscreveTextoId(string id, string value)
        {
            driver.FindElement(By.Id(id)).SendKeys(value);
        }

        public void EscreveTextoName(string name, string value)
        {
            driver.FindElement(By.Name(name)).SendKeys(value);
        }

        public void EscreveTextoXpath(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }


        public void ClicaBotaoId(string id)
        {
            driver.FindElement(By.Id(id)).Click();
        }

        public void ClicaBotaoName(string name)
        {
            driver.FindElement(By.Name(name)).Click();
        }

        public void ClicaBotaoXpath(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public void ValidaDados(string? xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }



    }
}
