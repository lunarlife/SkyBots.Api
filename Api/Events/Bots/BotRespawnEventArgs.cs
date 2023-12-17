using SkyBots.Api.Components.Entities.Bots;

namespace SkyBots.Api.Events.Bots;

public class BotRespawnEventArgs : BotEventArgs
{
    public BotRespawnEventArgs(BotComponent bot) : base(bot)
    {
    }
}