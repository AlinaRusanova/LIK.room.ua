using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AutoMapper;

namespace LIK.Application.Common.Mappings
{
   public class AssemblyMappingProfile: Profile
    {
        public AssemblyMappingProfile(Assembly assembly) =>
            ApplyMappingsFromAssembly(assembly);


        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()    // скан сборки
                    .Where(type => type.GetInterfaces()   // поиск любого типа, реализующего IMapWith
                    .Any(i => i.IsGenericType &&
                    i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                    .ToList();

            // вызов метода Mapping от наследуемго типа или из IMapWith, если тип не реализует метод
            foreach (var type in types)
            { var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
