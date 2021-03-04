namespace GW2Api.NET.V2.Achievements.Dto
{
    public record DailyAchievementDetail(
        int Id,
        LevelRange Level,
        RequiredAccess RequiredAccess
    );
}
