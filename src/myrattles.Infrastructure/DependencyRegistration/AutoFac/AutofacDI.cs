using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace myrattles.Infrastructure
{
    public class AutofacDi
    {
        public AutofacDi()
        {
            
        }

        public IServiceProvider DependencyInjection(IServiceCollection services)
        {
            var containerBuilder = new ContainerBuilder();

            //The Autofac Module will do all the Custom Registration You need.
            containerBuilder.RegisterModule<AutofacModule>();

            //The following Steps Populates AutoFAc with the services that were populated before 
            containerBuilder.Populate(services);

            var container = containerBuilder.Build();
            return container.Resolve<IServiceProvider>();

        }

        public IEnumerable<Assembly> GetLoadingAssesmblies()
        {
            return Assembly.GetEntryAssembly().GetRattlesAssemblies();           
        }
        
         
    }
}