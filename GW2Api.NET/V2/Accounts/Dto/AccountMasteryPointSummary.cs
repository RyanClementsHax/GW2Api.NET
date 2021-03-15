using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record AccountMasteryPointSummary(
        IList<MasteryPointRegionTotal> Totals,
        IList<int> Unlocked
    );
}
