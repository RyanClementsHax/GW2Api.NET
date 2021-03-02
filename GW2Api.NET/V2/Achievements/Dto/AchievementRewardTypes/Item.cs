using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.Achievements.Dto.AchievementRewardTypes
{
    [JsonDiscriminator("Item")]
    public record Item(
        int Id,
        int Count
    ) : AchievementReward();
}
