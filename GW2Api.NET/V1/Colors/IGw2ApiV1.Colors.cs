using GW2Api.NET.V1.Colors.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyDictionary<string, Color>> GetAllColorsAsync(CultureInfo lang = null, CancellationToken token = default);
    }
}
