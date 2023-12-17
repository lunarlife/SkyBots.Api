using SkyBots.Api.Components.Entities;
using SkyBots.Api.Entities;
using Undefined.Events;

namespace SkyBots.Api.Events.Entities;

public abstract class TransformChangedEventArgs : IEventArgs
{
    public Transform Transform { get; }
    public IEntity Entity { get; }

    public TransformChangedEventArgs(Transform transform)
    {
        Transform = transform;
        Entity = transform.Entity;
    }
}