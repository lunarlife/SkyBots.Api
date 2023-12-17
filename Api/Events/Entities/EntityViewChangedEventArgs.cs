using SkyBots.Api.Components.Entities;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Events.Entities;

public class EntityViewChangedEventArgs : TransformChangedEventArgs
{
    public View Old { get; }
    public View New { get; }

    public EntityViewChangedEventArgs(Transform transform, View old, View @new) : base(transform)
    {
        Old = old;
        New = @new;
    }
}