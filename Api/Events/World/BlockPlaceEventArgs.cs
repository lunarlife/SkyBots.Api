using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Events.World;

public class BlockPlaceEventArgs : BlockEventArgs
{
    public Block Old { get; }

    public BlockPlaceEventArgs(Bot bot, Block old, Block @new) : base(bot, @new)
    {
        Old = old;
    }
}