using System;

namespace GW2Api.NET.V1.Events
{
    public record EventDetails(
        Guid Id,
        string Name,
        int Level,
        int MapId
    );
}
