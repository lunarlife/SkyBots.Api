using SkyBots.Api.Events.Tasks;
using SkyBots.Api.Jobs.Instructions;
using Undefined.Events;

namespace SkyBots.Api.Components.Entities.Bots.TaskMachine;

public interface ISkyTask
{
    public bool IsCompleted { get; }
    public IEventAccess<ITaskCompletedEventArgs<ISkyTask>> OnCompleted { get; }
    public Bot Bot { get; }


    public Task<ISkyTask> WaitAsync();
    public ISkyTask Wait();
    public WaitTask WaitJob();
}

public interface ISkyTask<T> : ISkyTask where T : class, ISkyTask<T>
{
    public new IEventAccess<ITaskCompletedEventArgs<T>> OnCompleted { get; }

    IEventAccess<ITaskCompletedEventArgs<ISkyTask>> ISkyTask.OnCompleted => OnCompleted;

    ISkyTask ISkyTask.Wait() => Wait();
    async Task<ISkyTask> ISkyTask.WaitAsync() => await WaitAsync();
    public new T Wait();
    public WaitTask WaitJob(out T task);
    public new Task<T> WaitAsync();
}