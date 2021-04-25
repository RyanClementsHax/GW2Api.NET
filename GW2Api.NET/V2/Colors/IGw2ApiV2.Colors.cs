using GW2Api.NET.V2.Colors.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllColorIdsAsync(CancellationToken token = default);
        Task<Color> GetColorAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Color>> GetColorsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Color>> GetAllColorsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Color>>> GetColorsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
