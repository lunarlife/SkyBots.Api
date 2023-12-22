using SkyBots.Api.Components.Entities.Bots.TaskMachine;

namespace SkyBots.Api.Jobs.Instructions;

public class WaitTask : IInstruction
{
    private readonly ISkyTask _task;

    public WaitTask(ISkyTask task)
    {
        _task = task;
    }

    public bool IsReady() => _task.IsCompleted;

    public void Reset()
    {
    }
}