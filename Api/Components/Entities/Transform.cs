using SkyBots.Api.Events.Bots.Navigate;
using SkyBots.Api.Mathematics;
using SkyBots.Api.Worlds;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities;

public abstract class Transform : Component
{
    public abstract Vector3<float> Position { get; }
    public abstract IWorld World { get; }
    public abstract IEventAccess<EntityPositionChangedEventArgs> OnMoved { get; }
}