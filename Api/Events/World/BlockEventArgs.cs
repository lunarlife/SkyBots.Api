using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Events.Bots;
using SkyBots.Api.Worlds;

namespace SkyBots.Api.Events.World;

public abstract class BlockEventArgs : BotEventArgs
{
    public IBlock Block { get; }

    public BlockEventArgs(Bot bot, IBlock block) : base(bot)
    {
        Block = block;
    }
}