namespace SkyBotsApi;

public static class App
{
    private static SkyBots Instance => SkyBots.Implementation;
    public static IPluginManager PluginManager => Instance.PluginManager;
}