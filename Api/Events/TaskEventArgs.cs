using SkyBots.Api.Plugins.Internal.TaskMachine;
using Undefined.Events;

namespace SkyBots.Api.Events;

public class TaskEventArgs : IEventArgs
{
    public ITask Task { get; }

    
    public TaskEventArgs(ITask task)
    {
        Task = task;
    }
}