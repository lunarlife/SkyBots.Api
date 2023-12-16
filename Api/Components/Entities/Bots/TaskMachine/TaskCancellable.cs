namespace SkyBots.Api.Components.Entities.Bots.TaskMachine;

public abstract class TaskCancellable : SkyTask
{
    public abstract void Cancel();
}