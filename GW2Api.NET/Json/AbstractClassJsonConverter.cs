using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json
{
    internal class AbstractClassJsonConverter<T> : JsonConverter<T> where T : class
    {
        private IDictionary<string, Type> _discriminatorToTypeMap;

        public AbstractClassJsonConverter()
            => _discriminatorToTypeMap = Assembly.GetAssembly(typeof(T))
                .GetTypes()
                .Where(x => x.IsClass && x.IsSubclassOf(typeof(T)) && x.GetCustomAttributes(typeof(JsonDiscriminatorAttribute)).Any())
                .ToDictionary(
                    x => ((JsonDiscriminatorAttribute)x.GetCustomAttribute(typeof(JsonDiscriminatorAttribute))).Discriminator,
                    x => x
                );

        public override bool CanConvert(Type typeToConvert) =>
            typeToConvert.IsAssignableFrom(typeof(T));

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                if (doc.RootElement.TryGetProperty("type", out var typeProp))
                {
                    var typeValue = typeProp.GetString();

                    if (_discriminatorToTypeMap.TryGetValue(typeValue, out var type))
                    {
                        return JsonSerializer.Deserialize(doc.RootElement.GetRawText(), type, options) as T;
                    }
                    else
                    {
                        throw new JsonException($"{typeValue} has not been mapped to a custom type yet!");
                    }
                }

                throw new JsonException("Failed to extract type property, it might be missing?");
            }

            throw new JsonException("Failed to parse JsonDocument");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
