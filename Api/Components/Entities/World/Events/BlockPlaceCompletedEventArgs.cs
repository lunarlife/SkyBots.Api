using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Components.Entities.World.Events;

public class BlockPlaceCompletedEventArgs : BlockChangeCompletedEventArgs
{
    public BlockPlaceCompletedEventArgs(SkyTask task, Bot bot, BlockChangeResult result, Block oldBlock, Block newBlock)
        : base(task, bot, result, oldBlock, newBlock)
    {
    }
}