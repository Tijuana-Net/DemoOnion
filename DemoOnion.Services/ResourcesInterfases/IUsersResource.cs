using DemoOnion.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnion.Services.ResourcesInterfases
{
    public interface IUsersResource
    {
        public List<Usuarios> GetAll();
        public void Insert(Usuarios usuario);
        public void Update(Usuarios usuario);
        public void Delete(int id);
    }
}
