using SkyBots.Api.Bots;

namespace SkyBots.Api.Components.Entities.Bots;

public abstract class BotComponent : Component
{
    public abstract BotNumber BotNumber { get; }
    public abstract bool IsBound { get; }
    public abstract Task<BotBindResult> Bind(BotBindArgs args);
    public abstract void Unbind();
}