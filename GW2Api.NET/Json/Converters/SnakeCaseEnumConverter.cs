using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json.Converters
{
    internal class SnakeCaseEnumConverter<T> : JsonConverter<T> where T : struct, IConvertible
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => JsonDocument.TryParseValue(ref reader, out var doc)
                ? (T)Enum.Parse(typeToConvert, doc.RootElement.ToString().Replace("_", ""), ignoreCase: true)
                : throw new JsonException("Failed to parse JsonDocument");

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            => throw new NotImplementedException();
    }
}
