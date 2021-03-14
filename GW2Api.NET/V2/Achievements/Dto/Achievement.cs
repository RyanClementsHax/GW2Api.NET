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
        IList<AchievementFlag> Flags,
        IList<AchievementTier> Tiers,
        IList<int> Prerequisites,
        IList<AchievementReward> Rewards,
        IList<AchievementBit> Bits,
        int? PointCap
    );
}
