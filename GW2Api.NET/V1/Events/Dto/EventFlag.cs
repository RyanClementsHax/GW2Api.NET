using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Events.Dto
{
    [JsonConverter(typeof(SnakeCaseEnumConverter<EventFlag>))]
    public enum EventFlag
    {
        GroupEvent,
        MapWide,
        MetaEvent,
        DungeonEvent
    }
}
