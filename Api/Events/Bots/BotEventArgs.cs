using SkyBots.Api.Components.Entities.Bots;
using Undefined.Events;

namespace SkyBots.Api.Events.Bots;

public abstract class BotEventArgs : IEventArgs
{
    public BotComponent Bot { get; }
    public BotEventArgs(BotComponent bot)
    {
        Bot = bot;
    }
}