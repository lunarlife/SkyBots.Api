using SkyBots.Api.Core;
using SkyBots.Api.Core.Internal;
using SkyBots.Api.Events.Core;
using SkyBots.Api.Inventories;
using SkyBots.Api.Jobs;
using SkyBots.Api.Jobs.Instructions;
using SkyBots.Api.Worlds;
using Undefined.Events;

namespace SkyBots.Api;

public static class App
{
    private static SkyBotsBase Instance => SkyBotsBase.Implementation;


    public static IAppFactory Factory => Instance.Factory;
    public static bool IsEnabled => Instance.IsEnabled;
    public static IIsland Island => Instance.Island;
    public static IWorld World => Instance.World;
    public static IDebug Debug => Instance.Debug;
    public static IInventoriesManager InventoriesManager => Instance.InventoriesManager;
    public static IEventAccess<TickEventArgs> OnTick => Instance.ProgramLoop.OnTick;
    public static IEventAccess<FixedTickEventArgs> OnFixedTick => Instance.ProgramLoop.OnFixedTick;
    public static IJob ExecuteJob(IEnumerable<IInstruction?> job) => Instance.JobManager.ExecuteJob(job);
}