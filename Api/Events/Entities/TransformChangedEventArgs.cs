using SkyBots.Api.Components.Entities;
using Undefined.Events;

namespace SkyBots.Api.Events.Entities;

public abstract class TransformChangedEventArgs : IEventArgs
{
    public Transform Component { get; }

    public TransformChangedEventArgs(Transform component)
    {
        Component = component;
    }
}