using SkyBots.Api.Events.Bots.Navigate;
using SkyBots.Api.Math;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities;

public abstract class Transform : Component
{
    public abstract Vector3<float> Position { get; }
    public abstract IEventAccess<EntityPositionChangedEventArgs> OnMoved { get; }
}