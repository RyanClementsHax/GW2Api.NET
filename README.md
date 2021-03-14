# GW2Api.NET

This is a C# wrapper around `https://api.guildwars2.com/` written as a dotnet core library. This is a work in progress, but feel free to try out!

## V2

### Usage
All you have to do is instantiate an instance of `Gw2ApiV2` with an `HttpClient` to start using!
```cs
IGw2ApiV2 api = new Gw2ApiV2(new HttpClient())
```

### Accessing authenticated endpoints
To access authenticated endpoints, you need to create an [Api Key](https://wiki.guildwars2.com/wiki/API:API_key) with the permissions you desire. You have two ways of setting the Api Key.
1. Set the `ApiKey` property of the `Gw2ApiV2` instance you create. This will serve as the default Api Key for all authenticated requests you use on this instance.
	```cs
    var api = new Gw2ApiV2(new HttpClient())
    {
        ApiKey = "<your api key>"
    };

    var result = await api.GetAccountAsync();
	```
1. Pass it in as an argument to the function you want to call (only functions that access authenticated resources will have this paramater exposed). This key will be used over any key that is set to the `ApiKey` property.
	```cs
	var api = new Gw2ApiV2(new HttpClient());

    var result = await api.GetAccountAsync("<your api key>");
	```
Note that if no Api Keys are given, calling functions that need authentication will result in 401 Unauthenticated exceptions thrown.

## Development

### Running authenticated integration tests
1. Create an [Api Key](https://wiki.guildwars2.com/wiki/API:API_key) with Arena Net and give it all permissions
2. Create a `v2.config.json` in `GW2Api.NET.IntegrationTests` and fill it with data from your account for the tests to assert on
	```json
	{
	  "ApiKey": "<your api key>",
	  "AccountConfig": {
	    "Name": "<your account name>",
		"AchievementIds": [ 1, 2, 3 ],
		"DailyCraftingIds": [],
		"DungeonIds": [],
		"DyeIds": [ 1634, 1640, 1649 ],
		"FinisherIds": [ 1, 2, 62 ],
		"GliderIds": [ 78 ],
		"HomeCatIds": []
	  }
	}
	```
	- `ApiKey`: The Api Key to use in the tests (should have all permissions)
	- `AccountConfig`
		- `Name`: Your account's name
		- `AchievementIds`: A list of some ids of the achievements your account has
		- `DailyCraftingIds`: A list of some ids of the time gated crafting ids your account has completed today
		- `DungeonIds`: A list of some ids of the dungeons account has completed today
		- `DyeIds`: A list of some ids of the dyes your account has
		- `FinisherIds`: A list of some ids of the finishers your account has
		- `GliderIds`: A list of some ids of the gliders your account has
		- `HomeCatIds`: A list of some ids of the cats in your home instance your account has unlocked
	- Note that in the authenticated tests, we use partial matching of data to avoid brittle tests because account data is changing if the acccount is being used or played on
		- For example, we dont want to assert that the ids we get back from fetching all account achievement ids is exactly equal to some fixed set of numbers because that account could complete another achievement later down the road thus breaking the assertion even though the function works as it should
3. Run the authenticated tests in visual studio
