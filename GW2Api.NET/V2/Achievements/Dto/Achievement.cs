using System.Collections.Generic;

namespace GW2Api.NET.V2.Achievements.Dto
{
    public record Achievement(
        int Id,
        string Icon,
        string Name,
        string Description,
        string Requirement,
        string LockedText,
        AchievementType Type,
        IReadOnlyCollection<AchievementFlag> Flags,
        IReadOnlyCollection<AchievementTier> Tiers,
        IReadOnlyCollection<int> Prerequisites,
        IReadOnlyCollection<AchievementReward> Rewards,
        IReadOnlyCollection<AchievementBit> Bits,
        int? PointCap
    );
}
