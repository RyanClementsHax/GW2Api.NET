using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record GuildTreasurySlot(
        int ItemId,
        int Count,
        IList<UpgradeReservationInfo> NeededBy
    );
}
