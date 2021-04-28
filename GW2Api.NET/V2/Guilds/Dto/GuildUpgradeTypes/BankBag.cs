using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto.GuildUpgradeTypes
{
    public record BankBag(
        int Id,
        string Name,
        string Description,
        Uri Icon,
        int BuildTime,
        int RequiredLevel,
        int Experience,
        IList<int> Prerequisites,
        IList<GuildUpgradeCost> Costs,

        int BagMaxItems,
        int BagMaxCoins
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
