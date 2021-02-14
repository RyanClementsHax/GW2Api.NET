using GW2Api.NET.V1.Events;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IDictionary<Guid, EventDetails>> GetAllAvailableEventsDetails(int? worldId = null, int? mapId = null, string eventId = null, CancellationToken token = default);
    }
}
