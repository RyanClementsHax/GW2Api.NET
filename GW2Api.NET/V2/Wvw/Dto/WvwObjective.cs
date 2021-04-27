using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwObjective(
        string Id,
        WvwObjectiveType Type,
        WvwOwner Owner,
        DateTimeOffset LastFlipped,
        Guid? ClaimedBy,
        DateTimeOffset? ClaimedAt,
        int PointsTick,
        int PointsCapture,
        IList<int> GuildUpgrades,
        int YaksDelivered
    );
}