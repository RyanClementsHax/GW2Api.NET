using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwAbility(
        int Id,
        string Name,
        string Description,
        Uri Icon,
        IList<WvwAbilityRank> Ranks
    );
}
