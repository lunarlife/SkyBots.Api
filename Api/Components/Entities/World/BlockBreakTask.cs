using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Components.Entities.World.Events;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.World;

public abstract class BlockBreakTask : BlockChangeTask, ISkyTaskCancellable
{
    public abstract override IEventAccess<BlockBreakCompletedEventArgs> OnCompleted { get; }
    public abstract void Cancel();
}