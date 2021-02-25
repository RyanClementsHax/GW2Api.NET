using GW2Api.NET.Json.Attributes;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Common;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.UpgradeComponent.UpgradeTypes
{
    [JsonDiscriminator("Rune")]
    public record Rune(
        IReadOnlyCollection<UpgradeComponentFlag> Flags,
        double AttributeAdjustment,
        IReadOnlyCollection<InfusionType> InfusionUpgradeFlags,
        InfixUpgrade InfixUpgrade,
        string Suffix,

        IReadOnlyCollection<string> Bonuses
    ) : UpgradeComponentSubDetail(
        Flags,
        AttributeAdjustment,
        InfusionUpgradeFlags,
        InfixUpgrade,
        Suffix
    );
}
