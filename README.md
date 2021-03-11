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
		"AccountAchievements": [ 1, 2, 3 ]
	  }
	}
	```
	- `ApiKey`: The Api Key to use in the tests (should have all permissions)
	- `AccountConfig`
		- `Name`: Your account's name
		- `AccountAchievements`: A list of some ids of the achievements your account has
3. Run the authenticated tests in visual studio
