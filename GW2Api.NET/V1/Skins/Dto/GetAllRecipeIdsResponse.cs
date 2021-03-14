using System.Collections.Generic;

namespace GW2Api.NET.V1.Skins.Dto
{
    internal record GetAllSkinIdsResponse(
        IList<int> Skins
    );
}
