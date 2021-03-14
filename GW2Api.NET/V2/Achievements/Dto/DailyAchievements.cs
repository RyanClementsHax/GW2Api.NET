using System.Collections.Generic;

namespace GW2Api.NET.V2.Achievements.Dto
{
    public record DailyAchievements(
        IList<DailyAchievementDetail> Pve,
        IList<DailyAchievementDetail> Pvp,
        IList<DailyAchievementDetail> Wvw,
        IList<DailyAchievementDetail> Fractals,
        IList<DailyAchievementDetail> Special
    );
}
