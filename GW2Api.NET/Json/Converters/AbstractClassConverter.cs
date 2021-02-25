using GW2Api.NET.Json.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json.Converters
{
    internal class AbstractClassConverter<T> : JsonConverter<T> where T : class
    {
        private readonly IDictionary<string, Type> _discriminatorToTypeMap = new Dictionary<string, Type>();
        private readonly string _discriminatorFieldName;

        public AbstractClassConverter()
        {
            _discriminatorFieldName = ((JsonDiscriminatorFieldNameAttribute)typeof(T).GetCustomAttribute(typeof(JsonDiscriminatorFieldNameAttribute)))?.FieldName ?? "type";
            var types = Assembly.GetAssembly(typeof(T))
                .GetTypes()
                .Where(x =>
                    x.IsClass
                    && x.IsSubclassOf(typeof(T))
                    && x.GetCustomAttributes(typeof(JsonDiscriminatorAttribute)).Any()
                );
            foreach (var type in types)
            {
                var discriminator = ((JsonDiscriminatorAttribute)type.GetCustomAttribute(typeof(JsonDiscriminatorAttribute)))
                    .Discriminator
                    .ToLower();
                if (!_discriminatorToTypeMap.TryAdd(discriminator, type))
                {
                    _discriminatorToTypeMap.TryGetValue(discriminator, out var existingType);
                    throw new JsonException($"Multiple types declared the same discriminator for the same {nameof(AbstractClassConverter<T>)}: {type.FullName} and {existingType.FullName}");
                }
            }
        }

        public override bool CanConvert(Type typeToConvert) =>
            typeof(T).IsAssignableFrom(typeToConvert);

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                if (doc.RootElement.TryGetProperty(_discriminatorFieldName, out var typeProp))
                {
                    var typeValue = typeProp.GetString();

                    return _discriminatorToTypeMap.TryGetValue(typeValue.ToLower(), out var type)
                        ? JsonSerializer.Deserialize(doc.RootElement.GetRawText(), type, options) as T
                        : throw new JsonException($"{typeValue} has not been mapped to a custom type yet!");
                }

                throw new JsonException("Failed to extract type property, it might be missing?");
            }

            throw new JsonException("Failed to parse JsonDocument");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
