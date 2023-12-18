using SkyBots.Api.Components.Entities.World.Events;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.World;

public abstract class BlockPlaceTask : BlockChangeTask
{
    public abstract override IEventAccess<BlockPlaceCompletedEventArgs> OnCompleted { get; }
}