using GW2Api.NET.Json.Attributes;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.UpgradeComponent.UpgradeTypes
{
    [JsonDiscriminator("Rune")]
    public record Rune(
        IList<UpgradeComponentFlag> Flags,
        double AttributeAdjustment,
        IList<InfusionType> InfusionUpgradeFlags,
        InfixUpgrade InfixUpgrade,
        string Suffix,

        IList<string> Bonuses
    ) : UpgradeComponentSubDetail(
        Flags,
        AttributeAdjustment,
        InfusionUpgradeFlags,
        InfixUpgrade,
        Suffix
    );
}
