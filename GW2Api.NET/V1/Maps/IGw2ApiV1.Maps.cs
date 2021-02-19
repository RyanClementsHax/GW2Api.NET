using GW2Api.NET.V1.Maps.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyCollection<MapName>> GetAllMapNames(CultureInfo lang = null, CancellationToken token = default);
    }
}
