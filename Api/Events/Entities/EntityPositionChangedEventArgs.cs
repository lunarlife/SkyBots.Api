using SkyBots.Api.Components.Entities;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Events.Entities;

public class EntityPositionChangedEventArgs : TransformChangedEventArgs
{
    public Vector3<float> Old { get; }
    public Vector3<float> New { get; }

    public EntityPositionChangedEventArgs(Transform transform, Vector3<float> old, Vector3<float> @new) :
        base(transform)
    {
        Old = old;
        New = @new;
    }
}