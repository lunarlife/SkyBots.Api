using SkyBots.Api.Components.Entities.Bots;

namespace SkyBots.Api.Events.Bots;

public class BotHurtEventArgs : BotEventArgs
{
    public float OldHealth { get; }
    public float NewHealth { get; }

    public BotHurtEventArgs(Bot bot, float oldHealth, float newHealth) : base(bot)
    {
        OldHealth = oldHealth;
        NewHealth = newHealth;
    }
}