using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwOverview(
        string Id,
        DateTimeOffset StartTime,
        DateTimeOffset EndTime,
        IDictionary<ServerColor, int> Worlds,
        IDictionary<ServerColor, IList<int>> AllWorlds
    );
}
