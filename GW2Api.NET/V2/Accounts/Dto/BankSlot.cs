﻿using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record BankSlot(
        int Id,
        int Count,
        int? Charges,
        int? Skin,
        IList<int> Upgrades,
        IList<int> Infusions,
        AccountBinding Binding,
        string BoundTo
    );
}
