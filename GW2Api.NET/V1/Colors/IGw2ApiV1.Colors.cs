using GW2Api.NET.V1.Colors;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyDictionary<string, Color>> GetAllColorsAsync(CultureInfo cultureInfo, CancellationToken token = default);
    }
}
