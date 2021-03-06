﻿using GW2Api.NET.V2.Commerce.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Delivery> GetDeliveryAsync(string accessToken = null, CancellationToken token = default);
        Task<ExchangeInfo> GetCoinsToGemsExchangeInfoAsync(int quantity, CancellationToken token = default);
        Task<ExchangeInfo> GetGemsToCoinsExchangeInfoAsync(int quantity, CancellationToken token = default);
        Task<IList<int>> GetAllItemListingIdsAsync(CancellationToken token = default);
        Task<ItemListing> GetItemListingAsync(int id, CancellationToken token = default);
        Task<IList<ItemListing>> GetItemListingsAsync(IEnumerable<int> ids, CancellationToken token = default);
        Task<Page<IList<ItemListing>>> GetItemListingsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
        Task<IList<int>> GetAllMarketPriceIdsAsync(CancellationToken token = default);
        Task<MarketPrice> GetMarketPriceAsync(int id, CancellationToken token = default);
        Task<IList<MarketPrice>> GetMarketPricesAsync(IEnumerable<int> ids, CancellationToken token = default);
        Task<Page<IList<MarketPrice>>> GetMarketPricesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
        Task<Page<IList<Transaction>>> GetCurrentBuyTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
        Task<Page<IList<Transaction>>> GetCurrentSellTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
        Task<Page<IList<Transaction>>> GetHistoricalBuyTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
        Task<Page<IList<Transaction>>> GetHistoricalSellTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
    }
}
