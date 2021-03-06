﻿using GW2Api.NET.V1.Items.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _itemsResource = "items.json";
        private static readonly string _itemDetailsResource = "item_details.json";

        public async Task<IList<int>> GetAllItemIdsAsync(CancellationToken token = default)
            => (await GetAsync<GetAllItemIdsResponse>(_itemsResource, token)).Items;

        public Task<ItemDetail> GetItemDetailAsync(int itemId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<ItemDetail>(
                _itemDetailsResource,
                new Dictionary<string, string>
                {
                    { "item_id", itemId.ToString() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
