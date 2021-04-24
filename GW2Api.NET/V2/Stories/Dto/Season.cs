using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Stories.Dto
{
    public record Season(
        Guid Id,
        string Name,
        int Order,
        IList<int> Stories
    );
}
