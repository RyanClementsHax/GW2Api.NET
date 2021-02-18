using GW2Api.NET.V1.Events;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyDictionary<Guid, EventDetails>> GetAllAvailableEventsDetails(string eventId = null, CultureInfo cultureInfo = null, CancellationToken token = default);
    }
}
