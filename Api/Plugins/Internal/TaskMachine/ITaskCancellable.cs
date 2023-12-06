namespace SkyBots.Api.Plugins.Internal.TaskMachine;

public interface ITaskCancellable : ITask
{
    public void Cancel();
}