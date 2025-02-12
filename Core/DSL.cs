using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Core
{
    public class DSL : GlobalVariables
    {
        #region Função de manipulação

        public static void Espere(int time) => Thread.Sleep(time);

        #endregion

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

        public void ValidaDadosId(string? id, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var elemento = wait.Until(driver =>
            {
                var el = driver.FindElement(By.Id(id));
                return (el.Displayed && el.Enabled) ? el : null;
            });

            Assert.That(elemento.Text, Does.Contain(value));
        }

        public void EstaLogado()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Url.Contains("/videos"));

            Assert.That(driver.Url, Does.Contain("https://saph-dev.rs.true.com.br/videos"));
        }

    }
}
