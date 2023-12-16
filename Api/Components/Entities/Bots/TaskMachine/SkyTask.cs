using SkyBots.Api.Events.Tasks;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.TaskMachine;

public abstract class SkyTask
{
    public abstract bool IsCompleted { get; }
    public abstract IEventAccess<ITaskCompletedEventArgs> OnCompleted { get; }
}