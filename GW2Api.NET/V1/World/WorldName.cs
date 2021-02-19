using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.World
{
    public record WorldName(
        [property: JsonPropertyName("id")] string WorldId,
        string Name
    )
    {
        public WorldRegion WorldRegion
        {
            get => (WorldRegion)WorldId[0] - 48;
        }
    };
}
