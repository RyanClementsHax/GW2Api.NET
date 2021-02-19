using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json
{
    public class DefaultEnumConverter<T> : JsonConverter<T> where T : struct, IConvertible
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                return (T)Enum.Parse(typeToConvert, doc.RootElement.ToString(), ignoreCase: true);
            }

            throw new JsonException("Failed to parse JsonDocument");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
