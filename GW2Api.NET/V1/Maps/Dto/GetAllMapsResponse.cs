using System.Collections.Generic;

namespace GW2Api.NET.V1.Maps.Dto
{
    internal record GetAllMapsResponse(
        IDictionary<string, Map> Maps
    );
}
