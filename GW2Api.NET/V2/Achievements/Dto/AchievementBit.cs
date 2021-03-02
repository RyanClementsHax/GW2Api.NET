namespace GW2Api.NET.V2.Achievements.Dto
{
    public record AchievementBit(
        AchievementBitType Type,
        int? Id,
        string Text
    );
}
