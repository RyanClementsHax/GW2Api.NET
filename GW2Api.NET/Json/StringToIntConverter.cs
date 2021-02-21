using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json
{
    internal class StringToIntConverter : JsonConverter<int>
    {

        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetString();
            if (int.TryParse(reader.GetString(), out var result))
            {
                return result;
            }
            else
            {
                throw new JsonException($"Failed to parse as int: {str}");
            }
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
