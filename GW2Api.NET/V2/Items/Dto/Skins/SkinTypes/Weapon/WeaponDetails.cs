using GW2Api.NET.V2.Items.Dto.ItemTypes.Weapon;

namespace GW2Api.NET.V2.Items.Dto.Skins.SkinTypes.Weapon
{
    public record WeaponDetails(
        WeaponType Type,
        DamageType DamageType
    );
}
