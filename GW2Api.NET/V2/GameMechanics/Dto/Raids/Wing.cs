using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Raids
{
    public record Wing(
        string Id,
        IList<WingEvent> Events
    );
}