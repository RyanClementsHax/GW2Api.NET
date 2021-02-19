using GW2Api.NET.Helpers;
using GW2Api.NET.Json;
using GW2Api.NET.V1.Guilds;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1 : IGw2ApiV1
    {
        private readonly Uri _baseAddress = new Uri("https://api.guildwars2.com/v1/");
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
            Converters =
            {
                new DefaultEnumConverter<EmblemFlag>(),
                new JsonStringEnumMemberConverter(new SnakeCaseNamingPolicy()),
                new Vector3JsonConverter(),
                new Vector2JsonConverter()
            },
        };

        public Gw2ApiV1(HttpClient httpClient)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _httpClient.BaseAddress ??= _baseAddress;
        }

        private Task<T> GetAsync<T>(string resource, CancellationToken token = default)
            => GetAsync<T>(resource, new Dictionary<string, string>(), token);

        private Task<T> GetAsync<T>(string resource, IDictionary<string, string> paramMap, CancellationToken token = default)
        {
            if (resource is null) throw new ArgumentNullException(nameof(resource));
            if (paramMap is null) throw new ArgumentNullException(nameof(paramMap));

            return _httpClient.GetFromJsonAsync<T>(resource.AddParams(paramMap), _serializerOptions, token);
        }
    }
}
