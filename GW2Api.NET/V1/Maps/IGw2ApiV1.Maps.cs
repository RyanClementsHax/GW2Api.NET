using GW2Api.NET.V1.Maps;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyCollection<MapName>> GetAllMapNames(CultureInfo cultureInfo = null, CancellationToken token = default);
    }
}
