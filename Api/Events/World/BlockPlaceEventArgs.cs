using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Events.Bots;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Events.World;

public class BlockPlaceEventArgs : BlockEventArgs
{
    public Block Old { get; }

    public BlockPlaceEventArgs(BotComponent bot, Block old, Block @new) : base(bot, @new)
    {
        Old = old;
    }
}