using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Upgrade
{
    public record Upgrade(
        int Id,
        DateTimeOffset Time,
        string User,

        UpgradeAction Action,
        int UpgradeId,
        int? RecipeId
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
