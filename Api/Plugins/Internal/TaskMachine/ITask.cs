using SkyBots.Api.Events;
using Undefined.Events;

namespace SkyBots.Api.Plugins.Internal.TaskMachine;

public interface ITask
{
    public IEventAccess<TaskCompleteEventArgs> OnComplete { get; }
}