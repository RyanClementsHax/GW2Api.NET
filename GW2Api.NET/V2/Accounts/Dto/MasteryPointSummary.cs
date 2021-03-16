using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record MasteryPointSummary(
        IList<MasteryPointRegionTotal> Totals,
        IList<int> Unlocked
    );
}
