using GW2Api.NET.V1.Events.Locations;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Events
{
    public record EventDetails(
        Guid Id,
        string Name,
        int Level,
        int MapId,
        IReadOnlyCollection<EventFlag> Flags,
        Location Location
    );
}
