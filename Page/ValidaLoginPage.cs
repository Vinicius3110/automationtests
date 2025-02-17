using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core;

namespace TestProject.Page
{
    class ValidaLoginPage : Begin
    {

        public void FazLogin()
        {
            EscreveTextoId("Username", "vinicius.ritter");
            EscreveTextoId("Password", "Viniritter3110!");

        }

        public void ClicaBotaoLogin()
        {
            ClicaBotaoName("button");
        }   

        public void EsperaCarregar()
        {
            Espere(5000);
        }

        public void ValidaLogin()
        {
            EstaLogado();
        }


    }
}
