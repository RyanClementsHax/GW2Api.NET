namespace GW2Api.NET.V2.Guilds.Dto
{
    public record GuildUpgradeCost(
        GuildUpgradeCostType Type,
        string Name,
        int Count,
        int? ItemId
    );
}