using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using Undefined.Events;

namespace SkyBots.Api.Events.Tasks;

public class TaskEnabledEventArgs : IEventArgs
{
    public ISkyTask Task { get; }


    public TaskEnabledEventArgs(ISkyTask task)
    {
        Task = task;
    }
}