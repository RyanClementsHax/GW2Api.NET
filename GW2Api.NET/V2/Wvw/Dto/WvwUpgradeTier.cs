using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwUpgradeTier(
        string Name,
        int YaksRequired,
        IList<WvwUpgradeStep> Upgrades
    );
}