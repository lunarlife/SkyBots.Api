using SkyBots.Api.Events.Tasks;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.TaskMachine;

public abstract class TaskMachine : Component
{
    public abstract IEventAccess<TaskEnabledEventArgs> OnTaskEnabled { get; }
    public abstract IReadOnlyList<ISkyTask> EnabledTasks { get; }
    public abstract void EnableTask<T>(T task) where T : class, ISkyTask;
    public abstract void DisableTask<T>(T task) where T : class, ISkyTask;
    public abstract T GetActiveTask<T>() where T : class, ISkyTask;
    public abstract bool TryGetActiveTask<T>(out T? task) where T : class, ISkyTask;
}