using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record GuildVaultSection(
        int UpgradeId,
        int Size,
        int Number,
        string Note,
        IList<GuildStashSlot> Inventory
    );
}
