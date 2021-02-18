using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json
{
    internal class Vector2JsonConverter : JsonConverter<Vector2>
    {
        public override Vector2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                var array = JsonSerializer.Deserialize<IList<float>>(doc.RootElement.GetRawText(), options);
                if (array.Count == 2)
                {
                    return new Vector2(array[0], array[1]);
                }

                throw new JsonException($"Expected 2 elements in the array, but got ${array.Count}");
            }

            throw new JsonException("Failed to parse JsonDocument");
        }

        public override void Write(Utf8JsonWriter writer, Vector2 value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
