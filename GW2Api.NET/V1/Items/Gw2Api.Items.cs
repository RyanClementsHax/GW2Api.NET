using GW2Api.NET.V1.Items.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _itemsResource = "items.json";

        public async Task<IReadOnlyCollection<int>> GetAllItemIds(CancellationToken token = default)
            => (await GetAsync<ItemsResponse>(_itemsResource, token)).Items;
    }
}
