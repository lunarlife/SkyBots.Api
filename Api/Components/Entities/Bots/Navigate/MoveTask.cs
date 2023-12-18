using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public abstract class MoveTask : SkyTask, ISkyTaskCancellable
{
    public abstract override IEventAccess<BotNavigateCompletedEventArgs> OnCompleted { get; }
    public abstract void Cancel();
}