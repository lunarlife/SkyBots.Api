namespace SkyBots.Api.Jobs.Instructions;

public interface IInstruction
{
    public InstructionStatus Status { get; }
    public bool Update();
    public void Reset();
    public void Cancel();
}