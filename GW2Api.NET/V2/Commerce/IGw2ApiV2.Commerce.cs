using GW2Api.NET.V2.Commerce.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Page<IList<Transaction>>> GetCurrentBuyTransactionsAsync(string accessToken = null, int page = -1, int pageSize = -1, CancellationToken token = default);
    }
}
