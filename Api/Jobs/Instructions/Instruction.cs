using SkyBots.Api.Exceptions;

namespace SkyBots.Api.Jobs.Instructions;

public abstract class Instruction : IInstruction
{
    public InstructionStatus Status { get; private set; } = InstructionStatus.Executing;

    public bool Update()
    {
        if (Status == InstructionStatus.NoStatus) Status = InstructionStatus.Executing;
        if (Status != InstructionStatus.Executing) return true;
        if (!IsReady()) return false;
        if (Status == InstructionStatus.Executing)
            Status = InstructionStatus.Completed;
        return true;
    }


    public void Reset()
    {
        Status = InstructionStatus.NoStatus;
        OnReset();
    }

    public void Cancel()
    {
        if (Status != InstructionStatus.Executing) throw new JobException("Job already completed.");
        Status = InstructionStatus.Cancelled;
        OnCancel();
    }

    protected abstract void OnCancel();
    protected abstract void OnReset();
    protected abstract bool IsReady();
}