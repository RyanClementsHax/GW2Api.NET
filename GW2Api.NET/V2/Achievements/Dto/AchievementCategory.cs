using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Achievements.Dto
{
    public record AchievementCategory(
        int Id,
        string Name,
        string Description,
        int Order,
        Uri Icon,
        IList<int> Achievements
    );
}
