using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json.Converters
{
    internal class StringToIntConverter : JsonConverter<int>
    {

        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetString();
            return int.TryParse(reader.GetString(), out var result) ? result : throw new JsonException($"Failed to parse as int: {str}");
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
            => throw new NotImplementedException();
    }
}
