using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Consumable
{
    public record ConsumableDetails(
        ConsumableType Type,
        string Description,
        UnlockType UnlockType,
        int? ColorId,
        int? RecipeId,
        IList<int> ExtraRecipeIds,
        int? GuildUpgradeId,
        int? ApplyCount,
        string Name,
        Uri Icon,
        IList<int> Skins
    );
}
