using System;

namespace GW2Api.NET.V2.Tokens
{
    [Flags]
    public enum Permissions
    {
        None = 0,
        Account = 1,
        Builds = 2,
        Characters = 4,
        Guilds = 8,
        Inventories = 16,
        Progression = 32,
        Pvp = 64,
        Tradingpost = 128,
        Unlocks = 256,
        Wallet = 512,
        All = 1023
    }
}
