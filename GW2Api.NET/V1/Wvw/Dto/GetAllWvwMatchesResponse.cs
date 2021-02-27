using System.Collections.Generic;

namespace GW2Api.NET.V1.Wvw.Dto
{
    internal record GetAllWvwMatchesResponse(
        IReadOnlyCollection<WvwMatch> WvwMatches
    );
}
