# V1 Client Method Documentation

- [V1 Client Method Documentation](#v1-client-method-documentation)
  - [Builds](#builds)
    - [build.json](#buildjson)
  - [Colors](#colors)
    - [colors.json](#colorsjson)
  - [Events](#events)
    - [event_details.json](#event_detailsjson)
  - [Files](#files)
    - [files.json](#filesjson)
  - [Guilds](#guilds)
    - [guild_details.json](#guild_detailsjson)
  - [Items](#items)
    - [items.json](#itemsjson)
    - [item_details.json](#item_detailsjson)
  - [Maps](#maps)
    - [continents.json](#continentsjson)
    - [maps.json](#mapsjson)
    - [map_floor.json](#map_floorjson)
  - [Recipes](#recipes)
    - [recipes.json](#recipesjson)
    - [recipe_details.json](#recipe_detailsjson)
  - [Skins](#skins)
    - [skins.json](#skinsjson)
    - [skin_details.json](#skin_detailsjson)
  - [World](#world)
    - [world_names.json](#world_namesjson)
  - [Wvw](#wvw)
    - [wvw/matches.json](#wvwmatchesjson)
    - [wvw/match_details.json](#wvwmatch_detailsjson)
    - [wvw/objective_names.json](#wvwobjective_namesjson)

## Builds

### [build.json](https://wiki.guildwars2.com/wiki/API:1/build)
```cs
Task<Build> GetBuildAsync(CancellationToken token = default);
```

## Colors

### [colors.json](https://wiki.guildwars2.com/wiki/API:1/colors)
```cs
Task<IDictionary<string, Color>> GetAllColorsAsync(CultureInfo lang = null, CancellationToken token = default);
```

## Events

### [event_details.json](https://wiki.guildwars2.com/wiki/API:1/event_details)
```cs
Task<IDictionary<Guid, EventDetail>> GetAllAvailableEventsDetailsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<EventDetail> GetEventDetailAsync(Guid eventId, CultureInfo lang = null, CancellationToken token = default);
```

## Files

### [files.json](https://wiki.guildwars2.com/wiki/API:1/files)
```cs
Task<IDictionary<string, File>> GetAllFilesAsync(CancellationToken token = default);
```

## Guilds

### [guild_details.json](https://wiki.guildwars2.com/wiki/API:1/guild_details)
```cs
Task<GuildDetail> GetGuildDetailAsync(Guid guildId, CancellationToken token = default);
```
```cs
Task<GuildDetail> GetGuildDetailAsync(string guildName, CancellationToken token = default);
```

## Items

### [items.json](https://wiki.guildwars2.com/wiki/API:1/items)
```cs
Task<IList<int>> GetAllItemIdsAsync(CancellationToken token = default);
```

### [item_details.json](https://wiki.guildwars2.com/wiki/API:1/item_details)
```cs
Task<ItemDetail> GetItemDetailAsync(int itemId, CultureInfo lang = null, CancellationToken token = default);
```

## Maps

### [continents.json](https://wiki.guildwars2.com/wiki/API:1/continents)
```cs
Task<IDictionary<string, Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default);
```

### [maps.json](https://wiki.guildwars2.com/wiki/API:1/maps)
```cs
Task<IList<MapName>> GetAllMapNamesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IDictionary<string, Map>> GetAllMapsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Map> GetMapAsync(string mapId, CultureInfo lang = null, CancellationToken token = default);
```

### [map_floor.json](https://wiki.guildwars2.com/wiki/API:1/map_floor)
```cs
Task<MapFloor> GetMapFloorAsync(string continentId, int floor, CultureInfo lang = null, CancellationToken token = default);
```

## Recipes

### [recipes.json](https://wiki.guildwars2.com/wiki/API:1/recipes)
```cs
Task<IList<int>> GetAllRecipeIdsAsync(CancellationToken token = default);
```

### [recipe_details.json](https://wiki.guildwars2.com/wiki/API:1/recipe_details)
```cs
Task<RecipeDetail> GetRecipeDetailAsync(int recipeId, CultureInfo lang = null, CancellationToken token = default);
```

## Skins

### [skins.json](https://wiki.guildwars2.com/wiki/API:1/skins)
```cs
Task<IList<int>> GetAllSkinIdsAsync(CancellationToken token = default);
```

### [skin_details.json](https://wiki.guildwars2.com/wiki/API:1/skin_details)
```cs
Task<SkinDetail> GetSkinDetailAsync(int skinId, CultureInfo lang = null, CancellationToken token = default);
```

## World

### [world_names.json](https://wiki.guildwars2.com/wiki/API:1/world_names)
```cs
Task<IList<WorldName>> GetAllWorldNamesAsync(CultureInfo lang = null, CancellationToken token = default);
```

## Wvw

### [wvw/matches.json](https://wiki.guildwars2.com/wiki/API:1/wvw/matches)
```cs
Task<IList<WvwMatch>> GetAllWvwMatchesAsync(CancellationToken token = default);
```

### [wvw/match_details.json](https://wiki.guildwars2.com/wiki/API:1/wvw/match_details)
```cs
Task<WvwMatchDetail> GetWvwMatchDetailAsync(string matchId, CancellationToken token = default);
```

### [wvw/objective_names.json](https://wiki.guildwars2.com/wiki/API:1/wvw/objective_names)
```cs
Task<IList<ObjectiveName>> GetWvwObjectiveNamesAsync(CultureInfo lang = null, CancellationToken token = default);
```
