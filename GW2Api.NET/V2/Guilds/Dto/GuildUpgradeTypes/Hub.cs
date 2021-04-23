using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto.GuildUpgradeTypes
{
    public record Hub(
        int Id,
        string Name,
        string Description,
        string Icon,
        int BuildTime,
        int RequiredLevel,
        int Experience,
        IList<int> Prerequisites,
        IList<GuildUpgradeCost> Costs
    ) : GuildUpgrade(
        Id,
        Name,
        Description,
        Icon,
        BuildTime,
        RequiredLevel,
        Experience,
        Prerequisites,
        Costs
    );
}
