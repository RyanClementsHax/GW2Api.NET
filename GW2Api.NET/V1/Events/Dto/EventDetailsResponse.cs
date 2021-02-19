using System;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Events.Dto
{
    internal record EventDetailsResponse(
        IReadOnlyDictionary<Guid, EventDetail> Events
    );
}
