using System.Collections.Generic;

namespace GW2Api.NET.IntegrationTests.V2.Accounts
{
    public class AccountConfig
    {
        public string Name { get; set; }
        public IReadOnlyCollection<int> AchievementIds { get; set; } = new List<int>();
        public IReadOnlyCollection<int> FinisherIds { get; set; } = new List<int>();
        public IReadOnlyCollection<int> DailyCraftingIds { get; set; } = new List<int>();
        public IReadOnlyCollection<int> DungeonIds { get; set; } = new List<int>();
        public IReadOnlyCollection<int> DyeIds { get; set; } = new List<int>();
        public IReadOnlyCollection<int> GliderIds { get; set; } = new List<int>();
        public IReadOnlyCollection<int> HomeCatIds { get; set; } = new List<int>();
    }
}
