using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.Achievements.Dto.AchievementRewardTypes
{
    [JsonDiscriminator("Mastery")]
    public record Mastery(
        int Id,
        Region Region
    ) : AchievementReward();
}
