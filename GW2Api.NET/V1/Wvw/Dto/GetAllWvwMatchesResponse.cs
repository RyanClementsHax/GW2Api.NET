using System.Collections.Generic;

namespace GW2Api.NET.V1.Wvw.Dto
{
    internal record GetAllWvwMatchesResponse(
        IList<WvwMatch> WvwMatches
    );
}
