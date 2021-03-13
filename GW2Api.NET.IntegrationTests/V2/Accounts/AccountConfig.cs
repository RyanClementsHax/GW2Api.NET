using System.Collections.Generic;

namespace GW2Api.NET.IntegrationTests.V2.Accounts
{
    public class AccountConfig
    {
        public string Name { get; set; }
        public IReadOnlyCollection<int> AchievementIds { get; set; }
        public IReadOnlyCollection<int> FinisherIds { get; set; }
        public IReadOnlyCollection<int> DyeIds { get; set; }
    }
}
