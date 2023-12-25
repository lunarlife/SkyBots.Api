using SkyBots.Api.Components;
using SkyBots.Api.Events.Entities;
using Undefined.Events;

namespace SkyBots.Api.Entities;

public interface IEntity : IComponentEntry
{
    public IEventAccess<EntityDeadEventArgs> OnDead { get; }
    public EntityType Type { get; }
    public EntityId Id { get; }
    public string Name { get; }
    public AliveStatus AliveStatus { get; }
    public bool IsAlive => AliveStatus == AliveStatus.Alive;
}