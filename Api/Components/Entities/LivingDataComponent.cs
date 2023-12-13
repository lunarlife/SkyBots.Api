namespace SkyBots.Api.Components.Entities;

public abstract class LivingDataComponent : Component
{
    public abstract float Health { get; }
    public abstract float Food { get; }
}