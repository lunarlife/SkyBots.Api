namespace SkyBots.Api.Jobs.Instructions;

public class WaitTicks : IInstruction
{
    private int _count;

    public WaitTicks(int count = 1)
    {
        Preconditions.Argument(count > 0, "Count of frames must be greater than 0.");
        _count = count;
    }
    public bool IsReady()
    {
        if (_count <= 0) return true;
        _count--;
        return false;
    }
}