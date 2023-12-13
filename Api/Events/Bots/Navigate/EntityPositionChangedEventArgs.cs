using SkyBots.Api.Components.Entities;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Events.Bots.Navigate;

public class EntityPositionChangedEventArgs : TransformChangedEventArgs
{
    public Vector3<float> Previous { get; }
    public Vector3<float> New { get; }

    public EntityPositionChangedEventArgs(Vector3<float> previous, Transform component) : base(component)
    {
        Previous = previous;
        New = component.Position;
    }
}