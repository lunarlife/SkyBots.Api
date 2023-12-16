using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using Undefined.Events;

namespace SkyBots.Api.Events.Tasks;

public interface ITaskEventArgs : IEventArgs
{
    public SkyTask Task { get; }
}