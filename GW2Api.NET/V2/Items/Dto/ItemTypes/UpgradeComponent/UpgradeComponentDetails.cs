using GW2Api.NET.V2.Items.Dto.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.UpgradeComponent
{
    public record UpgradeComponentDetails(
        UpgradeComponentType Type,
        IList<UpgradeComponentFlag> Flags,
        IList<InfusionUpgradeFlag> InfusionUpgradeFlags,
        string Suffix,
        InfixUpgrade InfixUpgrade,
        IList<string> Bonuses
    );
}
