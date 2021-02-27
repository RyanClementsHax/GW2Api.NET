using GW2Api.NET.V1.Maps.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyCollection<MapName>> GetAllMapNamesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<IReadOnlyDictionary<string, Map>> GetAllMapsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Map> GetMapAsync(string mapId, CultureInfo lang = null, CancellationToken token = default);
        Task<IReadOnlyDictionary<string, Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<MapFloor> GetMapFloorAsync(string continentId, int floor, CultureInfo lang = null, CancellationToken token = default);
    }
}
