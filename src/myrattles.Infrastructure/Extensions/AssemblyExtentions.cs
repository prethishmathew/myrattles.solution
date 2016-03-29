using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace System.Reflection
{
    public static class AssemblyExtentions
    {

        public static IEnumerable<Assembly>  GetRattlesAssemblies(this Assembly assembly)
        {
              return  assembly.GetLoadedModules().Where(x => x.Assembly.FullName.Contains("myrattles")).Select(x => x.Assembly);
        }

        
    }
}