using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record EquipmentAttributes(
        [property:JsonPropertyName("AgonyResistance")] int? AgonyResistance,
        [property:JsonPropertyName("BoonDuration")] int? BoonDuration,
        [property:JsonPropertyName("ConditionDamage")] int? ConditionDamage,
        [property:JsonPropertyName("ConditionDuration")] int? ConditionDuration,
        [property:JsonPropertyName("CritDamage")] int? CritDamage,
        [property:JsonPropertyName("Healing")] int? Healing,
        [property:JsonPropertyName("Power")] int? Power,
        [property:JsonPropertyName("Precision")] int? Precision,
        [property:JsonPropertyName("Toughness")] int? Toughness,
        [property:JsonPropertyName("Vitality")] int? Vitality
    );
}