using DemoOnion.Services.Models;
using DemoOnion.Services.ResourcesInterfases;
using DemoOnion.Services.ServicesInterfases;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnion.Services.Services
{
    public class UsuriosServices : IUsuariosServices
    {
        private readonly IUsersResource _usersResource;

        public UsuriosServices(IUsersResource usersResource)
        {
            _usersResource = usersResource;
        }

        public bool ChangePassword()
        {
            throw new NotImplementedException();
        }

        public Usuarios GetPerfil()
        {
            throw new NotImplementedException();
        }

        public bool Login()
        {
            throw new NotImplementedException();
        }

        public bool Registro()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePerfil(Usuarios usuario)
        {
            throw new NotImplementedException();
        }
    }
}
