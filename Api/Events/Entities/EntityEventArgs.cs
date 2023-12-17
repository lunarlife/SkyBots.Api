using SkyBots.Api.Entities;
using Undefined.Events;

namespace SkyBots.Api.Events.Entities;

public abstract class EntityEventArgs : IEventArgs
{
    public IEntity Entity { get; }

    public EntityEventArgs(IEntity entity)
    {
        Entity = entity;
    }
}