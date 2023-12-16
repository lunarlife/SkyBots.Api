using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Components.Entities.World;
using SkyBots.Api.Events.Tasks;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Events.World;

public class BlockChangeCompletedEventArgs : ITaskCompletedEventArgs
{
    public BlockChangeResult Result { get; }
    public Block OldBlock { get; }
    public Block NewBlock { get; }

    public BlockChangeCompletedEventArgs(SkyTask task, BlockChangeResult result, Block oldBlock, Block newBlock)
    {
        Task = task;
        Result = result;
        OldBlock = oldBlock;
        NewBlock = newBlock;
    }

    public SkyTask Task { get; }
}