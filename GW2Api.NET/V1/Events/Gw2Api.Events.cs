using GW2Api.NET.V1.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _eventsResource = "event_details.json";

        public async Task<IDictionary<Guid, EventDetails>> GetAllAvailableEventsDetails(int? worldId = null, int? mapId = null, string eventId = null, CancellationToken token = default)
            => (await GetAsync<EventDetailsResponse>(_eventsResource, token)).Events
                .ToDictionary(
                    x => x.Key,
                    x => x.Value with
                    {
                        Id = x.Key
                    }
                );
    }
}
