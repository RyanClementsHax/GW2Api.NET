using System;

namespace GW2Api.NET.V2.Tokens.Dto
{
    public record TokenInfo(
        Guid Id,
        string Name,
        Permissions Permissions
    );
}
