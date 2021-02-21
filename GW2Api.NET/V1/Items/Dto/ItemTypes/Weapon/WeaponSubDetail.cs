using GW2Api.NET.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Weapon
{
    public record WeaponSubDetail(
        string Type,
        string DamageType,
        [property: JsonConverter(typeof(StringToIntConverter))] int MinPower,
        [property: JsonConverter(typeof(StringToIntConverter))] int MaxPower,
        [property: JsonConverter(typeof(StringToIntConverter))] int Defense,
        IReadOnlyCollection<string> InfusionSlots,
        double AttributeAdjustment,
        object InfixUpgrade,
        [property: JsonConverter(typeof(StringToNullableIntConverter))] int? SuffixItemId,
        [property: JsonConverter(typeof(StringToNullableIntConverter))] int? SecondarySuffixItemId
    );
}
