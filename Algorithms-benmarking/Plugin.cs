using Algo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_benmarking
{
    public class Plugin
    {
        public List<Algorithm> ListAlgorithms;

        public Plugin()
        {
            ListAlgorithms = GetAlgorithms();
        }

        private List<Algorithm> GetAlgorithms()
        {
            List<Algorithm> rs = new List<Algorithm>();
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Algorithms\", "*.dll");
            Type _pluginType = typeof(Algorithm);

            foreach (var file in files)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(file);
                Assembly assembly = Assembly.Load(an);
                Type[] types = assembly.GetTypes();

                foreach (var t in types)
                {
                    if (!t.IsClass || t.IsNotPublic) continue;
                    if (t.GetInterface(_pluginType.FullName) != null)
                    {
                        var instance = (Algorithm) Activator.CreateInstance(t);
                        rs.Add(instance);
                    }
                }
            }

            return rs;
        }
    }
}
