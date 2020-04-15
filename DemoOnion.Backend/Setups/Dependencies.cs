using DemoOnion.Infraestructura.Resources;
using DemoOnion.Services.ResourcesInterfases;
using DemoOnion.Services.Services;
using DemoOnion.Services.ServicesInterfases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoOnion.Backend.Setups
{
    public static class Dependencies
    {
        public static void Initiate(IServiceCollection services) {
            services.AddTransient<IUsersResource, UsersResource>();
            services.AddTransient<IUsuariosServices, UsuriosServices>();
        }
    }
}
