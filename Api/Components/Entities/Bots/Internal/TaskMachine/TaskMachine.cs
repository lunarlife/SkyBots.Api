using SkyBots.Api.Events.Tasks;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.Internal.TaskMachine;

public abstract class TaskMachine : Component 
{
    public abstract IEventAccess<TaskEnabledEventArgs> OnTaskEnabled { get; }
    public abstract void EnableTask<T>(T task) where T : SkyTask;
    public abstract void DisableTask<T>(T task) where T : SkyTask;
}