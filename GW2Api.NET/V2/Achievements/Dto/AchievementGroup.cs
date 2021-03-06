using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Achievements.Dto
{
    public record AchievementGroup(
        Guid Id,
        string Name,
        string Description,
        int Order,
        IReadOnlyCollection<int> Categories
    );
}
