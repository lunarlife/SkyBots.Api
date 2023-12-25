namespace SkyBots.Api.Jobs.Instructions;

public abstract class Instruction : IInstruction
{
    public bool IsCancelled { get; private set; }

    public bool IsReady() => IsCancelled || CheckReady();

    protected abstract bool CheckReady();

    public void Reset()
    {
        IsCancelled = false;
        OnReset();
    }

    protected abstract void OnCancelled();
    protected abstract void OnReset();
    public void Cancel() => IsCancelled = true;
}