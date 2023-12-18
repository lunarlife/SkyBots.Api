using SkyBots.Api.Components.Entities.Bots;
using Undefined.Events;

namespace SkyBots.Api.Events.Bots;

public abstract class BotEventArgs : IEventArgs
{
    public Bot Bot { get; }

    public BotEventArgs(Bot bot)
    {
        Bot = bot;
    }
}