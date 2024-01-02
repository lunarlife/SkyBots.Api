using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Events.World;

public class BlockBreakEventArgs : BlockEventArgs
{
    public IBlock Old { get; }

    public BlockBreakEventArgs(Bot bot, IBlock old, IBlock @new) : base(bot, @new)
    {
        Old = old;
    }
}