using SkyBots.Api.Components.Entities;

namespace SkyBots.Api.Events.Entities;

public class EntityIsOnGroundChangedEventArgs : TransformChangedEventArgs
{
    public EntityIsOnGroundChangedEventArgs(Transform transform) : base(transform)
    {
    }
}