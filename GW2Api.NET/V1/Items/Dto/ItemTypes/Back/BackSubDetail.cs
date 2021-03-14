using GW2Api.NET.Json.Converters;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Back
{
    public record BackSubDetail(
        IList<InfusionSlot> InfusionSlots,
        double AttributeAdjustment,
        InfixUpgrade InfixUpgrade,
        [property: JsonConverter(typeof(StringToNullableIntConverter))] int? SuffixItemId,
        [property: JsonConverter(typeof(StringToNullableIntConverter))] int? SecondarySuffixItemId
    );
}
