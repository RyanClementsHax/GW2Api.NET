using GW2Api.NET.Helpers;
using GW2Api.NET.Json.Converters;
using GW2Api.NET.Json.NamingPolicies;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Tokens;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2 : IGw2ApiV2
    {
        private readonly Uri _baseAddress = new("https://api.guildwars2.com/v2/");
        private readonly string _schemaVersion = "2019-05-16T00:00:00.000Z";
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions = new()
        {
            PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
            Converters =
            {
                new EnumFlagsConverter<Permissions>(),
                new JsonStringEnumMemberConverter(),
                new Vector3JsonConverter(),
                new Vector2JsonConverter()
            },
        };

        public string ApiKey { get; set; }

        public Gw2ApiV2(HttpClient httpClient)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _httpClient.BaseAddress ??= _baseAddress;
        }

        internal Task<Page<T>> GetPageWithAuthAsync<T>(string resource, IDictionary<string, string> paramMap, string accessToken = null, CancellationToken token = default)
        {
            paramMap["access_token"] = accessToken ?? ApiKey;

            return GetPageAsync<T>(resource, paramMap, token);
        }

        internal async Task<Page<T>> GetPageAsync<T>(string resource, IDictionary<string, string> paramMap, CancellationToken token = default)
        {
            if (resource is null) throw new ArgumentNullException(nameof(resource));
            if (paramMap is null) throw new ArgumentNullException(nameof(paramMap));

            paramMap.TryAddSchemaVersion(_schemaVersion);

            var url = resource.AddParams(paramMap);

            var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, token);
            response.EnsureSuccessStatusCode();

            var data = await response.Content!.ReadFromJsonAsync<T>(_serializerOptions, token);

            return new Page<T>(
                data,
                PageSize: response.Headers.GetAsInt("x-page-size"),
                PageTotal: response.Headers.GetAsInt("x-page-total"),
                ResultCount: response.Headers.GetAsInt("x-result-count"),
                ResultTotal: response.Headers.GetAsInt("x-result-total")
            );
        }

        internal Task<T> GetWithAuthAsync<T>(string resource, string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<T>(
                resource,
                new Dictionary<string, string>(),
                accessToken,
                token
            );

        internal Task<T> GetWithAuthAsync<T>(string resource, IDictionary<string, string> paramMap, string accessToken = null, CancellationToken token = default)
        {
            paramMap["access_token"] = accessToken ?? ApiKey;

            return GetAsync<T>(resource, paramMap, token);
        }

        internal Task<T> GetAsync<T>(string resource, CancellationToken token = default)
            => GetAsync<T>(resource, new Dictionary<string, string>(), token);

        internal Task<T> GetAsync<T>(string resource, IDictionary<string, string> paramMap, CancellationToken token = default)
        {
            if (resource is null) throw new ArgumentNullException(nameof(resource));
            if (paramMap is null) throw new ArgumentNullException(nameof(paramMap));

            paramMap.TryAddSchemaVersion(_schemaVersion);

            var url = resource.AddParams(paramMap);
            return _httpClient.GetFromJsonAsync<T>(url, _serializerOptions, token);
        }
    }
}
