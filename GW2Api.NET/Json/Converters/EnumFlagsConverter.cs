using GW2Api.NET.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json.Converters
{
    internal class EnumFlagsConverter<T> : JsonConverter<T> where T : struct, IConvertible
    {
        public override bool CanConvert(Type typeToConvert)
            => typeToConvert.IsEnum && typeToConvert.GetCustomAttributes(typeof(FlagsAttribute), inherit: false).Any();

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                var array = JsonSerializer.Deserialize<IList<string>>(doc.RootElement.GetRawText(), options);
                return array.Select(x => (T)Enum.Parse(typeof(T), x, ignoreCase: true)).Combine();
            }

            throw new JsonException("Failed to parse JsonDocument");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            => throw new NotImplementedException();
    }
}
