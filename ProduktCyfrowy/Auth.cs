using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
namespace ProduktCyfrowy;

public class Auth
{
    private ProtectedSessionStorage protectedSessionStorage;
    private NavigationManager navManager;
    public Auth(ProtectedSessionStorage _protectedSessionStorage, NavigationManager _navManager)
    {
        protectedSessionStorage = _protectedSessionStorage;
        navManager = _navManager;
    }

    public async Task Login(Guid userId,bool isAdmin)
    {
        await protectedSessionStorage.SetAsync("loggedin", "true");
        await protectedSessionStorage.SetAsync("userId", userId);
        await protectedSessionStorage.SetAsync("isAdmin", isAdmin);
        navManager.NavigateTo(navManager.Uri, true);
    }

    public async Task<bool> IsLoggedIn()
    {
        var loggedIn = await protectedSessionStorage.GetAsync<string>("loggedin");
        if(loggedIn.Success && !string.IsNullOrEmpty(loggedIn.Value))
        {
            return loggedIn.Value == "true";
        }
        return false;
    }
}
