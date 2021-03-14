using GW2Api.NET.V1.Maps.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _mapNamesResource = "map_names.json";
        private static readonly string _mapsResource = "maps.json";
        private static readonly string _continentsResource = "continents.json";
        private static readonly string _mapFloorResource = "map_floor.json";

        public Task<IList<MapName>> GetAllMapNamesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<MapName>>(
                _mapNamesResource,
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public async Task<IDictionary<string, Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default)
            => (await GetAsync<GetAllContinentsResponse>(
                    _continentsResource,
                    new Dictionary<string, string>
                    {
                        { "lang", lang?.TwoLetterISOLanguageName }
                    },
                    token
                )).Continents.ToDictionary(
                    x => x.Key,
                    x => x.Value with
                    {
                        ContinentId = x.Key
                    }
                );

        public async Task<IDictionary<string, Map>> GetAllMapsAsync(CultureInfo lang = null, CancellationToken token = default)
            => (await GetAsync<GetAllMapsResponse>(
                _mapsResource,
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            )).Maps.ToDictionary(
                x => x.Key,
                x => x.Value with
                {
                    MapId = x.Key
                }
            );

        public async Task<Map> GetMapAsync(string MapId, CultureInfo lang = null, CancellationToken token = default)
            => (await GetAsync<GetAllMapsResponse>(
                _mapsResource,
                new Dictionary<string, string>
                {
                    { "map_id", MapId },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            )).Maps.ToDictionary(
                x => x.Key,
                x => x.Value with
                {
                    MapId = x.Key
                }
            ).First().Value;

        public async Task<MapFloor> GetMapFloorAsync(string continentId, int floor, CultureInfo lang = null, CancellationToken token = default)
        {
            var mapFloor = await GetAsync<MapFloor>(
                _mapFloorResource,
                new Dictionary<string, string>
                {
                    { "continent_id", continentId },
                    { "floor", floor.ToString() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

            return mapFloor with
            {
                Regions = mapFloor.Regions.ToDictionary(
                    x => x.Key,
                    x => x.Value with
                    {
                        RegionId = x.Key,
                        Maps = x.Value.Maps.ToDictionary(
                            y => y.Key,
                            y => y.Value with
                            {
                                MapId = y.Key
                            }
                        )
                    }
                )
            };
        }
    }
}
