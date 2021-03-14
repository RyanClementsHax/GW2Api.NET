using System.Collections.Generic;

namespace GW2Api.NET.IntegrationTests.V2.Accounts
{
    public record AccountConfig
    {
        public string Name { get; set; }
        public IEnumerable<int> AchievementIds { get; set; }
        public IEnumerable<int> FinisherIds { get; set; }
        public IEnumerable<int> DailyCraftingIds { get; set; }
        public IEnumerable<int> DungeonIds { get; set; }
        public IEnumerable<int> DyeIds { get; set; }
        public IEnumerable<int> GliderIds { get; set; }
        public IEnumerable<int> HomeCatIds { get; set; }
        public IEnumerable<string> HomeNodeIds { get; set; }
        public IEnumerable<int> SharedInventoryItemIds { get; set; }
        public IEnumerable<int> MailCarrierIds { get; set; }
        public IEnumerable<string> MapChestIds { get; set; }
    }
}
