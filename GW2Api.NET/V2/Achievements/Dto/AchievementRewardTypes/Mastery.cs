using GW2Api.NET.Json.Attributes;
using GW2Api.NET.V2.GameMechanics.Dto;

namespace GW2Api.NET.V2.Achievements.Dto.AchievementRewardTypes
{
    [JsonDiscriminator("Mastery")]
    public record Mastery(
        int Id,
        Region Region
    ) : AchievementReward();
}
