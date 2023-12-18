using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.World.Events;

public class BlockBreakCompletedEventArgs : BlockChangeCompletedEventArgs
{
    public BlockBreakCompletedEventArgs(SkyTask task, Bot bot, BlockChangeResult result, Block oldBlock, Block newBlock)
        : base(
            task, bot, result, oldBlock, newBlock)
    {
    }
}