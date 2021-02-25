using GW2Api.NET.Json.Converters;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Events.Dto.Locations
{
    [JsonConverter(typeof(AbstractClassConverter<Location>))]
    public abstract record Location(
        Vector3 Center
    );
}
