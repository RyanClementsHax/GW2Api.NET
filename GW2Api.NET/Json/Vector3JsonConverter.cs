using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GW2Api.NET.Json
{
    internal class Vector3JsonConverter : JsonConverter<Vector3>
    {
        public override Vector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                var array = JsonSerializer.Deserialize<IList<float>>(doc.RootElement.GetRawText(), options);
                if (array.Count == 3)
                {
                    return new Vector3(array[0], array[1], array[2]);
                }

                throw new JsonException($"Expected 3 elements in the array, but got ${array.Count}");
            }

            throw new JsonException("Failed to parse JsonDocument");
        }

        public override void Write(Utf8JsonWriter writer, Vector3 value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
