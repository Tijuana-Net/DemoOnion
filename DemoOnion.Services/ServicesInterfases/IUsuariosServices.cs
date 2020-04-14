using DemoOnion.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnion.Services.ServicesInterfases
{
    public interface IUsuariosServices
    {
        public bool Login();
        public bool Registro();
        public bool ChangePassword();
        public Usuarios GetPerfil();
        public bool UpdatePerfil(Usuarios usuario);
    }
}
