using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Tasks;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.World.Events;

public abstract class BlockChangeCompletedEventArgs : ITaskCompletedEventArgs
{
    public BlockChangeResult Result { get; }
    public Block OldBlock { get; }
    public Block NewBlock { get; }
    public Bot Bot { get; }

    public SkyTask Task { get; }

    public BlockChangeCompletedEventArgs(SkyTask task, Bot bot, BlockChangeResult result, Block oldBlock,
        Block newBlock)
    {
        Task = task;
        Bot = bot;
        Result = result;
        OldBlock = oldBlock;
        NewBlock = newBlock;
    }
}