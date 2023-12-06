namespace SkyBots.Api;

public static class App
{
    private static SkyBots Instance => SkyBots.Implementation;
    public static IPluginManager PluginManager => Instance.PluginManager;
    public static bool IsEnabled => Instance.IsEnabled;
    
}