namespace SkyBots.Api.Jobs.Instructions;

public interface IInstruction
{
    public bool IsCancelled { get; }

    public bool IsReady();
    public void Reset();
    public void Cancel();
}