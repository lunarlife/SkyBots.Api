using SkyBots.Api.Events;
using Undefined.Events;

namespace SkyBots.Api.Plugins.Internal.TaskMachine;

public interface ITaskMachinePlugin
{
    public IEventAccess<TaskEnabledEventArgs> OnTaskEnabled { get; }
    public void EnableTask<T>(T task) where T : ITask;
    public void DisableTask<T>(T task) where T : ITask;
}