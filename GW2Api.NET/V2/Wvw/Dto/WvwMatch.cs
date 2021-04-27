using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwMatch(
        string Id,
        DateTimeOffset StartTime,
        DateTimeOffset EndTime,
        IDictionary<ServerColor, int> Scores,
        IDictionary<ServerColor, int> Worlds,
        IDictionary<ServerColor, IList<int>> AllWorlds,
        IDictionary<ServerColor, int> Deaths,
        IDictionary<ServerColor, int> Kills,
        IDictionary<ServerColor, int> VictoryPoints,
        IList<WvwMap> Maps,
        IList<Skirmish> Skirmishes
    );
}
