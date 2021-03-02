using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.Achievements.Dto
{
    [JsonConverter(typeof(AbstractClassConverter<AchievementReward>))]
    public abstract record AchievementReward();
}
