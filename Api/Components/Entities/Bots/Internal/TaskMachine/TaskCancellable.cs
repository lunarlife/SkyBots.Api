using SkyBots.Api.Events.Bots.Navigate;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.Internal.TaskMachine;

public abstract class TaskCancellable : SkyTask
{
    public abstract override IEventAccess<BotMoveCompletedEventArgs> OnComplete { get; }
    public abstract void Cancel();
}