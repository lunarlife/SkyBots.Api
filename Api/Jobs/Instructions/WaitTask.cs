using SkyBots.Api.Components.Entities.Bots.TaskMachine;

namespace SkyBots.Api.Jobs.Instructions;

public class WaitTask : Instruction
{
    private readonly ISkyTask _task;

    public WaitTask(ISkyTask task)
    {
        _task = task;
    }

    protected override bool CheckReady() => _task.IsCompleted;

    protected override void OnCancelled()
    {
        if(_task is ISkyTaskCancellable cancellable) cancellable.Cancel();
        
    }

    protected override void OnReset()
    {
    }
}