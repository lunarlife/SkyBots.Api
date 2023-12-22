using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using Undefined.Events;

namespace SkyBots.Api.Events.Tasks;

public interface ITaskCompletedEventArgs<out T> : IEventArgs where T : ISkyTask
{
    public T Task { get; }
}