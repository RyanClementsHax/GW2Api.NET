using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwUpgrade(
        int Id,
        IList<WvwUpgradeTier> Tiers
    );
}
