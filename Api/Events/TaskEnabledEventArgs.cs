using SkyBots.Api.Plugins.Internal.TaskMachine;

namespace SkyBots.Api.Events;

public class TaskEnabledEventArgs : TaskEventArgs
{
    public TaskEnabledEventArgs(ITask task) : base(task)
    {
    }
}