using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record LeaderboardSettings(
        string Name,
        int? Duration,
        Guid Scoring,
        IList<SettingsTier> Tiers
    );
}