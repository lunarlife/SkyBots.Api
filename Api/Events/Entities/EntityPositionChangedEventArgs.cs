using SkyBots.Api.Components.Entities;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Events.Entities;

public class EntityPositionChangedEventArgs : TransformChangedEventArgs
{
    public Vector3<float> PreviousPosition { get; }

    public EntityPositionChangedEventArgs(Vector3<float> previousPosition, Transform component) : base(component)
    {
        PreviousPosition = previousPosition;
    }
}