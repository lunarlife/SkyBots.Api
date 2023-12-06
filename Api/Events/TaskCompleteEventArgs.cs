using SkyBots.Api.Plugins.Internal.TaskMachine;

namespace SkyBots.Api.Events;

public class TaskCompleteEventArgs : TaskEventArgs
{
    public TaskCompleteEventArgs(ITask task) : base(task)
    {
    }
}