using System.Collections.Generic;

namespace GW2Api.NET.V1.Wvw.Dto
{
    public record WvwMatchDetail(
        string MatchId,
        IList<int> Scores,
        IList<WvwMapDetail> Maps
    );
}
