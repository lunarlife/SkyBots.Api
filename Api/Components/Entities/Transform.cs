using SkyBots.Api.Events.Entities;
using SkyBots.Api.Mathematics;
using SkyBots.Api.Worlds;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities;

public abstract class Transform : Component
{
    public abstract Vector3<float> Position { get; }
    public abstract bool IsOnGround { get; }
    public abstract View View { get; }
    public abstract IWorld World { get; }
    public abstract IEventAccess<EntityPositionChangedEventArgs> OnPositionChanged { get; }
    public abstract IEventAccess<EntityViewChangedEventArgs> OnViewChanged { get; }
    public abstract IEventAccess<EntityIsOnGroundChangedEventArgs> OnIsOnGroundChanged { get; }
    
    public abstract IBlock BlockBelow { get; }
    public abstract IBlock BlockAbove { get; }
    public abstract IBlock BlockFeet { get; }
    public abstract IBlock BlockHead { get; }
}