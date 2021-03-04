using System.Collections.Generic;

namespace GW2Api.NET.V2.Achievements.Dto
{
    public record DailyAchievements(
        IReadOnlyCollection<DailyAchievementDetail> Pve,
        IReadOnlyCollection<DailyAchievementDetail> Pvp,
        IReadOnlyCollection<DailyAchievementDetail> Wvw,
        IReadOnlyCollection<DailyAchievementDetail> Fractals,
        IReadOnlyCollection<DailyAchievementDetail> Special
    );
}
