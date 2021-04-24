using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Stories.Dto
{
    public record StorySeason(
        Guid Id,
        string Name,
        int Order,
        IList<int> Stories
    );
}
