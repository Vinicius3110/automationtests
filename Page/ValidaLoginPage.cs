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

        public void ValidaLogin()
        {
            ValidaDados("/html/body/app-root/app-default-layout/div[2]/mat-sidenav-container/mat-sidenav-content/main/div/app-videos-list/div/div[2]/div/h1", "BEM-VINDO(A)!");
        }
    }
}
