using GW2Api.NET.V1.World.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyCollection<WorldName>> GetAllWorldNamesAsync(CultureInfo lang = null, CancellationToken token = default);
    }
}
