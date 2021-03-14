using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GW2Api.NET.IntegrationTests.V2
{
    public static class ConfigExt
    {
        public static T InitNullArrays<T>(this T source)
        {
            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.IsIEnumerableType() && source.IsPropertyNull(prop.Name))
                {
                    var typeArg = prop.PropertyType.GenericTypeArguments.First();
                    typeof(T).GetProperty(prop.Name).SetValue(source, Array.CreateInstance(typeArg, 0), index: null);
                }
            }

            return source;
        }

        private static bool IsIEnumerableType(this PropertyInfo source)
            => source.PropertyType.IsGenericType
                && source.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>);

        private static bool IsPropertyNull<T>(this T source, string propName)
            => typeof(T).GetProperty(propName).GetValue(source, index: null) == null;
    }
}
