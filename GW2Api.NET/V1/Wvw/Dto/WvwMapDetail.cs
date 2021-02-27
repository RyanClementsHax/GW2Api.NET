using System.Collections.Generic;

namespace GW2Api.NET.V1.Wvw.Dto
{
    public record WvwMapDetail(
        WvwMapDetailType Type,
        IReadOnlyCollection<int> Scores,
        IReadOnlyCollection<Objective> Objectives,
        IReadOnlyCollection<WvwBonus> Bonuses
    );
}
