using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.World;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.World;

public abstract class BlockBreakTask : SkyTaskCancellable
{
    public abstract override IEventAccess<BlockChangeCompletedEventArgs> OnCompleted { get; }
}