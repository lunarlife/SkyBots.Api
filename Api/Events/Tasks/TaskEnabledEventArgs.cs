using SkyBots.Api.Components.Entities.Bots.Internal.TaskMachine;

namespace SkyBots.Api.Events.Tasks;

public class TaskEnabledEventArgs : ITaskEventArgs
{
    public SkyTask Task { get; }
    public TaskEnabledEventArgs(SkyTask task)
    {
        Task = task;
    }

}