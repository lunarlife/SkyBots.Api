using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Bots.Navigate;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public abstract class MoveTask : TaskCancellable
{
    public abstract override IEventAccess<BotMoveCompletedEventArgs> OnCompleted { get; }
}