using System;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Events
{
    internal record EventDetailsResponse(
        IReadOnlyDictionary<Guid, EventDetails> Events
    );
}
