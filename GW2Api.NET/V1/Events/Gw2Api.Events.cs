using GW2Api.NET.V1.Events;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _eventsResource = "event_details.json";

        public async Task<IReadOnlyDictionary<Guid, EventDetail>> GetAllAvailableEventsDetails(CultureInfo lang = null, CancellationToken token = default)
            => (await GetAsync<EventDetailsResponse>(
                    _eventsResource,
                    new Dictionary<string, string>
                    {
                        { "lang", lang?.TwoLetterISOLanguageName }
                    },
                    token
                )).Events.ToDictionary(
                    x => x.Key,
                    x => x.Value with
                    {
                        Id = x.Key
                    }
                );

        public async Task<EventDetail> GetEventDetail(Guid eventId, CultureInfo lang = null, CancellationToken token = default)
            => (await GetAsync<EventDetailsResponse>(
                    _eventsResource,
                    new Dictionary<string, string>
                    {
                        { "event_id", eventId.ToString() },
                        { "lang", lang?.TwoLetterISOLanguageName }
                    },
                    token
                )).Events.ToDictionary(
                    x => x.Key,
                    x => x.Value with
                    {
                        Id = x.Key
                    }
                ).First().Value;
    }
}
