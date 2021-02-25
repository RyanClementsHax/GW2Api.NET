using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json.Converters
{
    internal class StringToBooleanConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetString() switch
            {
                "0" => false,
                "1" => true,
                var str => throw new JsonException($"Failed to parse as boolean: {str}")
            };

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
            => throw new NotImplementedException();
    }
}
