﻿using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Commerce.Dto;
using GW2Api.NET.V2.Common;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<Delivery> GetDeliveryAsync(string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<Delivery>(
                "commerce/delivery",
                accessToken,
                token
            );

        public Task<ExchangeInfo> GetCoinsToGemsExchangeInfoAsync(int quantity, CancellationToken token = default)
            => GetAsync<ExchangeInfo>(
                "commerce/exchange/coins",
                new Dictionary<string, string>
                {
                    { "quantity", quantity.ToString() }
                },
                token
            );

        public Task<ExchangeInfo> GetGemsToCoinsExchangeInfoAsync(int quantity, CancellationToken token = default)
            => GetAsync<ExchangeInfo>(
                "commerce/exchange/gems",
                new Dictionary<string, string>
                {
                    { "quantity", quantity.ToString() }
                },
                token
            );

        public Task<IList<int>> GetAllItemListingIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("commerce/listings", token);

        public Task<ItemListing> GetItemListingAsync(int id, CancellationToken token = default)
            => GetAsync<ItemListing>($"commerce/listings/{id}", token);

        public Task<IList<ItemListing>> GetItemListingsAsync(IEnumerable<int> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<ItemListing>>(
                "commerce/listings",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<Page<IList<ItemListing>>> GetItemListingsAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<ItemListing>>(
                "commerce/listings",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllMarketPriceIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("commerce/prices", token);

        public Task<MarketPrice> GetMarketPriceAsync(int id, CancellationToken token = default)
            => GetAsync<MarketPrice>($"commerce/prices/{id}", token);

        public Task<IList<MarketPrice>> GetMarketPricesAsync(IEnumerable<int> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<MarketPrice>>(
                "commerce/prices",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<Page<IList<MarketPrice>>> GetMarketPricesAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<MarketPrice>>(
                "commerce/prices",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );
        public Task<Page<IList<Transaction>>> GetCurrentBuyTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/current/buys",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );

        public Task<Page<IList<Transaction>>> GetCurrentSellTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/current/sells",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );
        public Task<Page<IList<Transaction>>> GetHistoricalBuyTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/history/buys",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );

        public Task<Page<IList<Transaction>>> GetHistoricalSellTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<Transaction>>(
                "commerce/transactions/history/sells",
                new Dictionary<string, string>().ConfigurePage(page, pageSize),
                accessToken,
                token
            );
    }
}
