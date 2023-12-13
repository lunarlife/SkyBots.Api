using SkyBots.Api.Worlds;

namespace SkyBots.Api;

public static class App
{
    private static SkyBotsBase Instance => SkyBotsBase.Implementation;
    public static bool IsEnabled => Instance.IsEnabled;
    public static IIsland Island => Instance.Island;
    public static IWorld World => Instance.World;
    public static IDebug Debug => Instance.Debug;
}