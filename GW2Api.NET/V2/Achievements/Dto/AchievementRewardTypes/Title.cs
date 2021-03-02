using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.Achievements.Dto.AchievementRewardTypes
{
    [JsonDiscriminator("Title")]
    public record Title(
        int Id
    ) : AchievementReward();
}
