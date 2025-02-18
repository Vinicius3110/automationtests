using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Page;

namespace TestProject.Test
{
    class ValidaLoginTest : ValidaLoginPage
    {
        [Test]
        public void ExecutaAutomacao()
        {
            FazLogin();
            ClicaBotaoLogin();
            EsperaCarregar();
            ValidaLogin();
            NavegaParaPagina();
        }
    }
}
