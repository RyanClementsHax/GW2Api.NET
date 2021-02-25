using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json.Converters
{
    internal class StringToNullableIntConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetString();
            return str == "" ? null : JsonSerializer.Deserialize(str, typeof(int), options) as int?;
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
            => throw new NotImplementedException();
    }
}
