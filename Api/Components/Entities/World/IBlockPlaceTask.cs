using SkyBots.Api.Components.Entities.Bots.TaskMachine;

namespace SkyBots.Api.Components.Entities.World;

public interface IBlockPlaceTask : IBlockChangeTask, ISkyTask<IBlockPlaceTask>
{
    public BlockPlaceResult Result { get; }
}