namespace SkyBots.Api.Components.Entities.Bots.TaskMachine;

public abstract class SkyTaskCancellable : SkyTask
{
    public abstract void Cancel();
}