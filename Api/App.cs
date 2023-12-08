namespace SkyBots.Api;

public static class App
{
    private static SkyBotsBase Instance => SkyBotsBase.Implementation;
    public static bool IsEnabled => Instance.IsEnabled;
    
}