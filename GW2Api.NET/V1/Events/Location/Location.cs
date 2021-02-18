using GW2Api.NET.Json;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Events.Locations
{
    [JsonConverter(typeof(AbstractClassJsonConverter<Location>))]
    public abstract record Location(
        Vector3 Center
    );
}
