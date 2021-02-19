using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Maps
{
    public record MapName(
        [property: JsonPropertyName("id")]
        string MapId,

        string Name
    );
}
