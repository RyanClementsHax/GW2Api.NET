using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record SharedInventorySlot(
        int Id,
        int Count,
        int? Charges,
        int? Skin,
        IList<int> Upgrades,
        IList<int> Infusions,
        AccountBinding Binding
    );
}
