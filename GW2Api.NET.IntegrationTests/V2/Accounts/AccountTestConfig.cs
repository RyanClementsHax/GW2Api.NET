using GW2Api.NET.V2.Maps.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GW2Api.NET.IntegrationTests.V2.Accounts
{
    public record AccountTestConfig
    {
        public string Name { get; set; }
        public IEnumerable<int> AchievementIds { get; set; }
        public int AchievementId
        {
            get
            {
                var id = AchievementIds.FirstOrDefault();
                if (id is 0)
                    Assert.Fail("You must configure at least one character id in v2.config.json to run this test");
                return id;
            }
        }
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
        public IEnumerable<int> MasteryIds { get; set; }
        public MasteryPointSummary MasteryPointSummaryData { get; set; }
        public IEnumerable<int> MinisIds { get; set; }
        public IEnumerable<int> MountSkinIds { get; set; }
        public IEnumerable<string> MountTypes { get; set; }
        public IEnumerable<int> NoveltyIds { get; set; }
        public IEnumerable<int> OutfitIds { get; set; }
        public IEnumerable<int> PvpHeroIds { get; set; }
        public IEnumerable<int> RaidIds { get; set; }
        public IEnumerable<int> RecipeIds { get; set; }
        public IEnumerable<int> SkinIds { get; set; }
        public IEnumerable<int> TitleIds { get; set; }
        public IEnumerable<int> CurrencyIds { get; set; }
        public IEnumerable<string> WorldBossIds { get; set; }

        public record MasteryPointSummary
        {
            public IEnumerable<Region> Regions { get; set; }
            public IEnumerable<int> MasteryIds { get; set; }
        };
    }
}
