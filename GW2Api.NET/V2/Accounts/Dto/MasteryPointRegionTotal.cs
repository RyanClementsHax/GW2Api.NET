﻿namespace GW2Api.NET.V2.Accounts.Dto
{
    public record MasteryPointRegionTotal(
        Region Region,
        int Spent,
        int Earned
    );
}
