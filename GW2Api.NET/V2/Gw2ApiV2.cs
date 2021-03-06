using GW2Api.NET.Helpers;
using GW2Api.NET.Json.Converters;
using GW2Api.NET.Json.NamingPolicies;
using GW2Api.NET.V1.Events.Dto;
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
                new SnakeCaseEnumConverter<EventFlag>(),
                new JsonStringEnumMemberConverter(),
                new Vector3JsonConverter(),
                new Vector2JsonConverter()
            },
        };

        public Gw2ApiV2(HttpClient httpClient)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _httpClient.BaseAddress ??= _baseAddress;
        }

        internal Task<T> GetAsync<T>(string resource, CancellationToken token = default)
            => GetAsync<T>(resource, new Dictionary<string, string>(), token);

        internal Task<T> GetAsync<T>(string resource, IDictionary<string, string> paramMap, CancellationToken token = default)
        {
            if (resource is null) throw new ArgumentNullException(nameof(resource));
            if (paramMap is null) throw new ArgumentNullException(nameof(paramMap));

            if (!paramMap.TryAdd("v", _schemaVersion))
                throw new InvalidOperationException($"This library only supports schema version: {_schemaVersion}");

            var url = resource.AddParams(paramMap);
            return _httpClient.GetFromJsonAsync<T>(url, _serializerOptions, token);
        }
    }
}
