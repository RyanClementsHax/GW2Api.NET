using GW2Api.NET.V1.Items.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IList<int>> GetAllItemIdsAsync(CancellationToken token = default);
        Task<ItemDetail> GetItemDetailAsync(int itemId, CultureInfo lang = null, CancellationToken token = default);
    }
}
