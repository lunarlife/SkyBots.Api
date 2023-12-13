using SkyBots.Api.Components;

namespace SkyBots.Api.Entities;

public interface IEntity : IComponentEntry
{
    public EntityType Type { get; }
    public EntityId Id { get; }
    public string Name { get; }
    public bool IsAlive { get; }
}