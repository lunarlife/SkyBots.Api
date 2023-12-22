namespace SkyBots.Api.Jobs.Instructions;

public class WaitTicks : IInstruction
{
    private int _ticksCount;
    private int _remain;

    public WaitTicks(int count = 1)
    {
        Preconditions.Argument(count > 0, "Count of frames must be greater than 0.");
        _ticksCount = count;
    }

    public bool IsReady()
    {
        if (_remain >= _ticksCount)
        {
            Reset();
            return true;
        }
        _remain++;
        return false;
    }

    public void Reset()
    {
        _remain = 0;
    }
}