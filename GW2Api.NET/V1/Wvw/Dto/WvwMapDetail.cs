using System.Collections.Generic;

namespace GW2Api.NET.V1.Wvw.Dto
{
    public record WvwMapDetail(
        WvwMapDetailType Type,
        IList<int> Scores,
        IList<Objective> Objectives,
        IList<WvwBonus> Bonuses
    );
}
