using SkyBots.Api.Components.Entities.Bots;

namespace SkyBots.Api.Events.Bots;

public class BotLevelChangeEventArgs : BotEventArgs
{
    public int OldLevel { get; }
    public int NewLevel { get; }

    public BotLevelChangeEventArgs(Bot bot, int oldLevel, int newLevel) : base(bot)
    {
        OldLevel = oldLevel;
        NewLevel = newLevel;
    }
}