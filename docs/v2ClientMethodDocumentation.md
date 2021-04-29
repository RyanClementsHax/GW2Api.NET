# V2 Client Method Documentation

- [V2 Client Method Documentation](#v2-client-method-documentation)
  - [Accounts](#accounts)
    - [account](#account)
    - [account/achievements](#accountachievements)
    - [account/bank](#accountbank)
    - [account/dailycrafting](#accountdailycrafting)
    - [account/dungeons](#accountdungeons)
    - [account/dyes](#accountdyes)
    - [account/finishers](#accountfinishers)
    - [account/gliders](#accountgliders)
    - [account/home/cats](#accounthomecats)
    - [account/home/nodes](#accounthomenodes)
    - [account/inventory](#accountinventory)
    - [account/luck](#accountluck)
    - [account/mailcarriers](#accountmailcarriers)
    - [account/mapchests](#accountmapchests)
    - [account/masteries](#accountmasteries)
    - [account/mastery/points](#accountmasterypoints)
    - [account/materials](#accountmaterials)
    - [account/minis](#accountminis)
    - [account/mounts/skins](#accountmountsskins)
    - [account/mounts/types](#accountmountstypes)
    - [account/novelties](#accountnovelties)
    - [account/outfits](#accountoutfits)
    - [account/pvp/heroes](#accountpvpheroes)
    - [account/raids](#accountraids)
    - [account/recipes](#accountrecipes)
    - [account/skins](#accountskins)
    - [account/titles](#accounttitles)
    - [account/wallet](#accountwallet)
    - [account/worldbosses](#accountworldbosses)
  - [Achievements](#achievements)
    - [achievements](#achievements-1)
    - [achievements/daily](#achievementsdaily)
    - [achievements/daily/tomorrow](#achievementsdailytomorrow)
    - [achievements/groups](#achievementsgroups)
    - [achievements/categories](#achievementscategories)

## Accounts

### [account](https://wiki.guildwars2.com/wiki/API:2/account)
```cs
Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default);
```

### [account/achievements](https://wiki.guildwars2.com/wiki/API:2/account/achievements)
```cs
Task<IList<AccountAchievement>> GetAllAccountAchievementsAsync(string accessToken = null, CancellationToken token = default);
```
```cs
Task<AccountAchievement> GetAccountAchievementAsync(int id, string accessToken = null, CancellationToken token = default);
```
```cs
Task<IList<AccountAchievement>> GetAccountAchievementsAsync(IEnumerable<int> ids, string accessToken = null, CancellationToken token = default);
```

### [account/bank](https://wiki.guildwars2.com/wiki/API:2/account/bank)
```cs
Task<IList<BankSlot>> GetAccountBankAsync(string accessToken = null, CancellationToken token = default);
```

### [account/dailycrafting](https://wiki.guildwars2.com/wiki/API:2/account/dailycrafting)
```cs
Task<IList<string>> GetAccountDailyCraftingIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/dungeons](https://wiki.guildwars2.com/wiki/API:2/account/dungeons)
```cs
Task<IList<string>> GetAccountDungeonIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/dyes](https://wiki.guildwars2.com/wiki/API:2/account/dyes)
```cs
Task<IList<int>> GetAccountDyeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/finishers](https://wiki.guildwars2.com/wiki/API:2/account/finishers)
```cs
Task<IList<FinisherSummary>> GetAccountFinisherSummariesAsync(string accessToken = null, CancellationToken token = default);
```

### [account/gliders](https://wiki.guildwars2.com/wiki/API:2/account/gliders)
```cs
Task<IList<int>> GetAccountGliderIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/home/cats](https://wiki.guildwars2.com/wiki/API:2/account/home/cats)
```cs
Task<IList<int>> GetAccountHomeCatIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/home/nodes](https://wiki.guildwars2.com/wiki/API:2/account/home/nodes)
```cs
Task<IList<string>> GetAccountHomeNodeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/inventory](https://wiki.guildwars2.com/wiki/API:2/account/inventory)
```cs
Task<IList<SharedInventorySlot>> GetAccountSharedInventorySlotsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/luck](https://wiki.guildwars2.com/wiki/API:2/account/luck)
```cs
Task<IList<ConsumedLuck>> GetAccountLuckAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mailcarriers](https://wiki.guildwars2.com/wiki/API:2/account/mailcarriers)
```cs
Task<IList<int>> GetAccountMailCarrierIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mapchests](https://wiki.guildwars2.com/wiki/API:2/account/mapchests)
```cs
Task<IList<string>> GetAccountMapChestIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/masteries](https://wiki.guildwars2.com/wiki/API:2/account/masteries)
```cs
Task<IList<MasterySummary>> GetAccountMasterySummariesAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mastery/points](https://wiki.guildwars2.com/wiki/API:2/account/mastery/points)
```cs
Task<MasteryPointSummary> GetAccountMasteryPointSummaryAsync(string accessToken = null, CancellationToken token = default);
```

### [account/materials](https://wiki.guildwars2.com/wiki/API:2/account/materials)
```cs
Task<IList<MaterialSummary>> GetAccountMaterialSummariesAsync(string accessToken = null, CancellationToken token = default);
```

### [account/minis](https://wiki.guildwars2.com/wiki/API:2/account/minis)
```cs
Task<IList<int>> GetAccountMinisIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mounts/skins](https://wiki.guildwars2.com/wiki/API:2/account/mounts/skins)
```cs
Task<IList<int>> GetAccountMountSkinIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mounts/types](https://wiki.guildwars2.com/wiki/API:2/account/mounts/types)
```cs
Task<IList<string>> GetAccountMountTypeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/novelties](https://wiki.guildwars2.com/wiki/API:2/account/novelties)
```cs
Task<IList<int>> GetAccountNoveltyIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/outfits](https://wiki.guildwars2.com/wiki/API:2/account/outfits)
```cs
Task<IList<int>> GetAccountOutfitIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/pvp/heroes](https://wiki.guildwars2.com/wiki/API:2/account/pvp/heroes)
```cs
Task<IList<int>> GetAccountPvpHeroIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/raids](https://wiki.guildwars2.com/wiki/API:2/account/raids)
```cs
Task<IList<string>> GetAccountRaidIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/recipes](https://wiki.guildwars2.com/wiki/API:2/account/recipes)
```cs
Task<IList<int>> GetAccountRecipeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/skins](https://wiki.guildwars2.com/wiki/API:2/account/skins)
```cs
Task<IList<int>> GetAccountSkinIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/titles](https://wiki.guildwars2.com/wiki/API:2/account/titles)
```cs
Task<IList<int>> GetAccountTitleIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/wallet](https://wiki.guildwars2.com/wiki/API:2/account/wallet)
```cs
Task<IList<CurrencySummary>> GetAccountWalletAsync(string accessToken = null, CancellationToken token = default);
```

### [account/worldbosses](https://wiki.guildwars2.com/wiki/API:2/account/worldbosses)
```cs
Task<IList<string>> GetAccountWorldBossIdsAsync(string accessToken = null, CancellationToken token = default);
```

## Achievements

### [achievements](https://wiki.guildwars2.com/wiki/API:2/achievements)
```cs
Task<IList<int>> GetAllAchievementIdsAsync(CancellationToken token = default);
```
```cs
Task<Achievement> GetAchievementAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Achievement>> GetAchievementsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Achievement>>> GetAchievementsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [achievements/daily](https://wiki.guildwars2.com/wiki/API:2/achievements/daily)
```cs
Task<DailyAchievements> GetTodaysDailyAchievementsAsync(CancellationToken token = default);
```

### [achievements/daily/tomorrow](https://wiki.guildwars2.com/wiki/API:2/achievements/daily/tomorrow)
```cs
Task<DailyAchievements> GetTomorrowsDailyAchievementsAsync(CancellationToken token = default);
```

### [achievements/groups](https://wiki.guildwars2.com/wiki/API:2/achievements/categories)
```cs
Task<IList<Guid>> GetAllAchievementGroupIdsAsync(CancellationToken token = default);
```
```cs
Task<AchievementGroup> GetAchievementGroupAsync(Guid id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementGroup>> GetAchievementGroupsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementGroup>> GetAllAchievementGroupsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<AchievementGroup>>> GetAchievementGroupsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [achievements/categories](https://wiki.guildwars2.com/wiki/API:2/achievements/categories)
```cs
Task<IList<int>> GetAllAchievementCategoryIdsAsync(CancellationToken token = default);
```
```cs
Task<AchievementCategory> GetAchievementCategoryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementCategory>> GetAchievementCategoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementCategory>> GetAllAchievementCategoriesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<AchievementCategory>>> GetAchievementCategorysAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```