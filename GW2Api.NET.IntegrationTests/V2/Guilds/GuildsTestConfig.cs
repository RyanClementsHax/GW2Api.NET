using System;
using System.Collections.Generic;

namespace GW2Api.NET.IntegrationTests.V2.Guilds
{
    public class GuildsTestConfig
    {
        public string ApiKey { get; set; }
        public Guid Id { get; set; }
        public IEnumerable<string> MemberNames { get; set; }
        public IEnumerable<string> RankIds { get; set; }
        public IEnumerable<string> TeamNames { get; set; }
        public IEnumerable<int> UpgradeIds { get; set; }
    }
}
