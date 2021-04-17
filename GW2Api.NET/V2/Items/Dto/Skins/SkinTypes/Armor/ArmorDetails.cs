using GW2Api.NET.V2.Items.Dto.ItemTypes.Armor;

namespace GW2Api.NET.V2.Items.Dto.Skins.SkinTypes.Armor
{
    public record ArmorDetails(
        ArmorType Type,
        WeightClass WeightClass,
        DyeSlots DyeSlots
    );
}
