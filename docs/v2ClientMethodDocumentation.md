# V2 Client Method Documentation

- [V2 Client Method Documentation](#v2-client-method-documentation)
  - [Achievements](#achievements)
    - [achievements](#achievements-1)
    - [achievements/daily](#achievementsdaily)
    - [achievements/daily/tomorrow](#achievementsdailytomorrow)
    - [achievements/groups](#achievementsgroups)
    - [achievements/categories](#achievementscategories)

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