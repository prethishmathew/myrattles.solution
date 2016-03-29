using System.CodeDom;

namespace myrattles.Infrastructure.DependencyRegistration.SimpleInjector
{
    public class SimpleInjector
    {

        private string _assemblyFolder;


        public SimpleInjector(string assemblyFolder)
        {
            _assemblyFolder = assemblyFolder;
        }


    }
}