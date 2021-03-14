using GW2Api.NET.Json.Converters;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.UpgradeComponent
{
    [JsonConverter(typeof(AbstractClassConverter<UpgradeComponentSubDetail>))]
    public abstract record UpgradeComponentSubDetail(
        IList<UpgradeComponentFlag> Flags,
        double AttributeAdjustment,
        IList<InfusionType> InfusionUpgradeFlags,
        InfixUpgrade InfixUpgrade,
        string Suffix
    );
}
