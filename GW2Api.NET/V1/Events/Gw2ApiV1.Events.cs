using GW2Api.NET.V1.Events.Dto;
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

        public async Task<IReadOnlyDictionary<Guid, EventDetail>> GetAllAvailableEventsDetailsAsync(CultureInfo lang = null, CancellationToken token = default)
            => (await GetAsync<GetAllAvailableEventsDetailsResponse>(
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
                        EventId = x.Key
                    }
                );

        public async Task<EventDetail> GetEventDetailAsync(Guid eventId, CultureInfo lang = null, CancellationToken token = default)
            => (await GetAsync<GetAllAvailableEventsDetailsResponse>(
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
                        EventId = x.Key
                    }
                ).First().Value;
    }
}
