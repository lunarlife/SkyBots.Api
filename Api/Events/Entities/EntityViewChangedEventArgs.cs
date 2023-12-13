using SkyBots.Api.Components.Entities;

namespace SkyBots.Api.Events.Entities;

public class EntityViewChangedEventArgs : TransformChangedEventArgs
{
    public float PreviousYaw { get; }
    public float PreviousPitch { get; }

    public EntityViewChangedEventArgs(Transform component, float previousYaw, float previousPitch) : base(component)
    {
        PreviousYaw = previousYaw;
        PreviousPitch = previousPitch;
    }
}