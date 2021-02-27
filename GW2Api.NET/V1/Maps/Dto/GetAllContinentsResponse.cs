using System.Collections.Generic;

namespace GW2Api.NET.V1.Maps.Dto
{
    internal record GetAllContinentsResponse(
        IReadOnlyDictionary<string, Continent> Continents
    );
}
