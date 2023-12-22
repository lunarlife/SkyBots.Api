using SkyBots.Api.Components.Entities.Bots;

namespace SkyBots.Api.Events.Bots;

public class BotBoundChangeEventArgs : BotEventArgs
{
    public bool IsBound { get; }
    public BotBoundChangeEventArgs(Bot bot) : base(bot)
    {
        IsBound = bot.IsBound;
    }
}