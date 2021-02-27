using GW2Api.NET.V1.Items.Dto.ItemTypes.Weapon;

namespace GW2Api.NET.V1.Skins.Dto.SkinTypes.Weapon
{
    public record WeaponSkinSubDetail(
        WeaponType Type,
        DamageType DamageType
    );
}
