using GW2Api.NET.Json.Converters;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Weapon
{
    public record WeaponSubDetail(
        WeaponType Type,
        DamageType DamageType,
        [property: JsonConverter(typeof(StringToIntConverter))] int MinPower,
        [property: JsonConverter(typeof(StringToIntConverter))] int MaxPower,
        [property: JsonConverter(typeof(StringToIntConverter))] int Defense,
        IList<InfusionType> InfusionSlots,
        double AttributeAdjustment,
        InfixUpgrade InfixUpgrade,
        [property: JsonConverter(typeof(StringToNullableIntConverter))] int? SuffixItemId,
        [property: JsonConverter(typeof(StringToNullableIntConverter))] int? SecondarySuffixItemId
    );
}
