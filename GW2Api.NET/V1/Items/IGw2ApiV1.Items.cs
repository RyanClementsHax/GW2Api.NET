using GW2Api.NET.V1.Items.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyCollection<int>> GetAllItemIds(CancellationToken token = default);
        Task<ItemDetail> GetItemDetail(int itemId, CultureInfo lang = null, CancellationToken token = default);
    }
}
