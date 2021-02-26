using GW2Api.NET.V1.Events.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyDictionary<Guid, EventDetail>> GetAllAvailableEventsDetailsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<EventDetail> GetEventDetailAsync(Guid eventId, CultureInfo lang = null, CancellationToken token = default);
    }
}
