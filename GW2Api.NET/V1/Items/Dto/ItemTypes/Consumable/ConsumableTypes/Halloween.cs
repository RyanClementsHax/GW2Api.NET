﻿using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes
{
    [JsonDiscriminator("Halloween")]
    public record Halloween() : ConsumableSubDetail();
}
