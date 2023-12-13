using SkyBots.Api.Components.Entities.Bots.Internal.TaskMachine;

namespace SkyBots.Api.Events.Tasks;

public class TaskEnabledEventArgs : ITaskEventArgs
{
    public TaskEnabledEventArgs(SkyTask task)
    {
        Task = task;
    }

    public SkyTask Task { get; }
}