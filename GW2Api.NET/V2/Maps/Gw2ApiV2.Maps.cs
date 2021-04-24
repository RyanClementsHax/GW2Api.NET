using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Maps.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetAllContinentIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("continents", token);

        public Task<Continent> GetContinentAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Continent>(
                $"continents/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Continent>> GetContinentsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Continent>>(
                "continents",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Continent>>(
                "continents",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Continent>>> GetContinentsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Continent>>(
                "continents",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllFloorIdsAsync(int continentId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors", token);

        public Task<Floor> GetFloorAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Floor>(
                $"continents/{continentId}/floors/{floorId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Floor>> GetFloorsAsync(int continentId, IEnumerable<int> floorIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (floorIds is null)
                throw new ArgumentNullException(nameof(floorIds));

            return GetAsync<IList<Floor>>(
                $"continents/{continentId}/floors",
                new Dictionary<string, string>
                {
                    { "ids", floorIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Floor>> GetAllFloorsAsync(int continentId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Floor>>(
                $"continents/{continentId}/floors",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Floor>>> GetFloorsAsync(int continentId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Floor>>(
                $"continents/{continentId}/floors",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllFloorRegionIdsAsync(int continentId, int floorId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors/{floorId}/regions", token);

        public Task<FloorRegion> GetFloorRegionAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<FloorRegion>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<FloorRegion>> GetFloorRegionsAsync(int continentId, int floorId, IEnumerable<int> regionIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (regionIds is null)
                throw new ArgumentNullException(nameof(regionIds));

            return GetAsync<IList<FloorRegion>>(
                $"continents/{continentId}/floors/{floorId}/regions",
                new Dictionary<string, string>
                {
                    { "ids", regionIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<FloorRegion>> GetAllFloorRegionsAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<FloorRegion>>(
                $"continents/{continentId}/floors/{floorId}/regions",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<FloorRegion>>> GetFloorRegionsAsync(int continentId, int floorId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<FloorRegion>>(
                $"continents/{continentId}/floors/{floorId}/regions",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllRegionMapIdsAsync(int continentId, int floorId, int regionId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps", token);

        public Task<RegionMap> GetRegionMapAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<RegionMap>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<RegionMap>> GetRegionMapsAsync(int continentId, int floorId, int regionId, IEnumerable<int> mapIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (mapIds is null)
                throw new ArgumentNullException(nameof(mapIds));

            return GetAsync<IList<RegionMap>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps",
                new Dictionary<string, string>
                {
                    { "ids", mapIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<RegionMap>> GetAllRegionMapsAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<RegionMap>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<RegionMap>>> GetRegionMapsAsync(int continentId, int floorId, int regionId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<RegionMap>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllSectorIdsAsync(int continentId, int floorId, int regionId, int mapId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/sectors", token);

        public Task<Sector> GetSectorAsync(int continentId, int floorId, int regionId, int mapId, int sectorId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Sector>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/sectors/{sectorId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Sector>> GetSectorsAsync(int continentId, int floorId, int regionId, int mapId, IEnumerable<int> sectorIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (sectorIds is null)
                throw new ArgumentNullException(nameof(sectorIds));

            return GetAsync<IList<Sector>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/sectors",
                new Dictionary<string, string>
                {
                    { "ids", sectorIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Sector>> GetAllSectorsAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Sector>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/sectors",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Sector>>> GetSectorsAsync(int continentId, int floorId, int regionId, int mapId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Sector>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/sectors",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllPointOfInterestIdsAsync(int continentId, int floorId, int regionId, int mapId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/pois", token);

        public Task<PointOfInterest> GetPointOfInterestAsync(int continentId, int floorId, int regionId, int mapId, int pointOfInterestId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<PointOfInterest>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/pois/{pointOfInterestId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<PointOfInterest>> GetPointsOfInterestAsync(int continentId, int floorId, int regionId, int mapId, IEnumerable<int> pointOfInterestIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (pointOfInterestIds is null)
                throw new ArgumentNullException(nameof(pointOfInterestIds));

            return GetAsync<IList<PointOfInterest>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/pois",
                new Dictionary<string, string>
                {
                    { "ids", pointOfInterestIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<PointOfInterest>> GetAllPointsOfInterestAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<PointOfInterest>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/pois",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<PointOfInterest>>> GetPointsOfInterestAsync(int continentId, int floorId, int regionId, int mapId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<PointOfInterest>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/pois",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllMapTaskIdsAsync(int continentId, int floorId, int regionId, int mapId, CancellationToken token = default)
            => GetAsync<IList<int>>($"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/tasks", token);

        public Task<MapTask> GetMapTaskAsync(int continentId, int floorId, int regionId, int mapId, int mapTaskId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<MapTask>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/tasks/{mapTaskId}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<MapTask>> GetMapTasksAsync(int continentId, int floorId, int regionId, int mapId, IEnumerable<int> mapTaskIds, CultureInfo lang = null, CancellationToken token = default)
        {
            if (mapTaskIds is null)
                throw new ArgumentNullException(nameof(mapTaskIds));

            return GetAsync<IList<MapTask>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/tasks",
                new Dictionary<string, string>
                {
                    { "ids", mapTaskIds.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<MapTask>> GetAllMapTasksAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<MapTask>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/tasks",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<MapTask>>> GetMapTasksAsync(int continentId, int floorId, int regionId, int mapId, int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<MapTask>>(
                $"continents/{continentId}/floors/{floorId}/regions/{regionId}/maps/{mapId}/tasks",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
        public Task<IList<int>> GetAllMapIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("maps", token);

        public Task<Map> GetMapAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Map>(
                $"maps/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Map>> GetMapsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Map>>(
                "maps",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Map>> GetAllMapsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Map>>(
                "maps",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Map>>> GetMapsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Map>>(
                "maps",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
