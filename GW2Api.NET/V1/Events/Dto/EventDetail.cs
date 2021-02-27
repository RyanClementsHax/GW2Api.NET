using GW2Api.NET.V1.Events.Dto.Locations;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Events.Dto
{
    public record EventDetail(
        Guid EventId,
        string Name,
        int Level,
        int MapId,
        IReadOnlyCollection<EventFlag> Flags,
        Location Location
    );
}
