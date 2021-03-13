using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record BankSlot(
        int Id,
        int Count,
        int? Charges,
        int? Skin,
        IReadOnlyCollection<int> Upgrades,
        IReadOnlyCollection<int> Infusions,
        AccountBinding Binding,
        string BoundTo
    );
}
