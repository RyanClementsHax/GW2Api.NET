using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GW2Api.NET.IntegrationTests.V2
{
    public static class ConfigExt
    {
        public static T InitNullIEnumerables<T>(this T source)
        {
            if (source is null)
                return source;

            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.IsIEnumerableType() && source.IsPropertyNull(prop.Name))
                {
                    var typeArg = prop.PropertyType.GenericTypeArguments.First();
                    typeof(T)
                        .GetProperty(prop.Name)
                        .SetValue(
                            obj: source,
                            value: Array.CreateInstance(typeArg, 0),
                            index: null
                        );
                }
                else if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                {
                    typeof(ConfigExt)
                        .GetMethod(nameof(InitNullIEnumerables))
                        .MakeGenericMethod(prop.PropertyType)
                        .Invoke(
                            obj: null,
                            parameters: new object[] {
                                source.GetPropertyValue(prop.Name)
                            }
                        );
                }
            }

            return source;
        }

        private static bool IsIEnumerableType(this PropertyInfo source)
            => source.PropertyType.IsGenericType
                && source.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>);

        private static bool IsPropertyNull(this object source, string propName)
            => source.GetPropertyValue(propName) is null;

        private static object GetPropertyValue(this object source, string propName)
            => source
                .GetType()
                .GetProperty(propName)
                .GetValue(source, index: null);
    }
}
