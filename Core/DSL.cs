using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Core
{
    public class DSL
    {
        private readonly GlobalVariables _globalVariables; // Use readonly para garantir que a referência não mude

        public DSL(GlobalVariables globalVariables)
        {
            _globalVariables = globalVariables ?? throw new ArgumentNullException(nameof(globalVariables)); // Lança exceção se globalVariables for null
        }

        public DSL()
        {
        }

        public void Espere(int time) => Thread.Sleep(time);

        public void EscreveTextoId(string id, string value)
        {
            _globalVariables.Driver.FindElement(By.Id(id)).SendKeys(value);
        }

        public void EscreveTextoName(string name, string value)
        {
            _globalVariables.Driver.FindElement(By.Name(name)).SendKeys(value);
        }

        public void EscreveTextoXpath(string xpath, string value)
        {
            _globalVariables.Driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClicaBotaoId(string id)
        {
            _globalVariables.Driver.FindElement(By.Id(id)).Click();
        }

        public void ClicaBotaoName(string name)
        {
            _globalVariables.Driver.FindElement(By.Name(name)).Click();
        }

        public void ClicaBotaoXpath(string xpath)
        {
            _globalVariables.Driver.FindElement(By.XPath(xpath)).Click();
        }

        public void ValidaDados(string? xpath, string value)
        {
            Assert.That(_globalVariables.Driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }

        public void ValidaDadosId(string? id, string value)
        {
            var elemento = _globalVariables.Wait.Until(driver =>
            {
                var el = _globalVariables.Driver.FindElement(By.Id(id));
                return (el.Displayed && el.Enabled) ? el : null;
            });

            Assert.That(elemento.Text, Does.Contain(value));
        }

        public void EstaLogado()
        {
            _globalVariables.Wait.Until(driver => driver.Url.Contains("/videos"));
            Assert.That(_globalVariables.Driver.Url, Does.Contain("https://saph-dev.rs.true.com.br/videos"));
        }

        public void IrParaPagina(string urlRelativa)
        {
            string urlBase = driver.Url;   
            
            string novaUrl = new Uri(new Uri(urlBase), urlRelativa).ToString();

            driver.Navigate().GoToUrl(novaUrl);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.Url.Contains(urlRelativa));
        }
    }
}