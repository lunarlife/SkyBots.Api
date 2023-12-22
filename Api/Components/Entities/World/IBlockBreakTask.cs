using SkyBots.Api.Components.Entities.Bots.TaskMachine;

namespace SkyBots.Api.Components.Entities.World;

public interface IBlockBreakTask : IBlockChangeTask, ISkyTask<IBlockBreakTask>, ISkyTaskCancellable
{
    public BlockBreakResult Result { get; }
}