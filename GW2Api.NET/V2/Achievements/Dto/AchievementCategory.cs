using System.Collections.Generic;

namespace GW2Api.NET.V2.Achievements.Dto
{
    public record AchievementCategory(
        int Id,
        string Name,
        string Description,
        int Order,
        string Icon,
        IReadOnlyCollection<int> Achievements
    );
}
