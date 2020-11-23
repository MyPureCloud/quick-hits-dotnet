// >> START sdk-overview This example demonstrates authorizing using a client credentials grant and getting a list of users
// Authorize SDK
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo");
Configuration.Default.AccessToken = accessTokenInfo.AccessToken;

// Set environment
PureCloudRegionHosts region = PureCloudRegionHosts.us_east_1;
Configuration.Default.ApiClient.setBasePath(region);

// Instantiate instance of the Users API
var usersApi = new UsersApi();

// Get the logged in user
var users = usersApi.GetUsers();
Console.WriteLine($"Users: {users}");
// >> END sdk-overview
