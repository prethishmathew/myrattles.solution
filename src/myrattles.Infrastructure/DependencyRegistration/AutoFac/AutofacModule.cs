using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Module = Autofac.Module;

namespace myrattles.Infrastructure
{ 
    public class AutofacModule:Module
    {

        public AutofacModule()
        {
            
        }

        protected override void Load(ContainerBuilder builder)
        {
            // For now Add the 


            var assemblies = Assembly.GetEntryAssembly().GetRattlesAssemblies();
            //.SelectMany(s => s.GetTypes())
            //        .Where(p => !p.IsAbstract && !p.IsInterface && p.IsClass); ;

            
            foreach (var assembly in assemblies)
            {
                builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces();

            }


            //ToDo: Get the custom dll and then register the Implementations as Self, this way the custom classes will override the defualt classes


        }
    }
}
