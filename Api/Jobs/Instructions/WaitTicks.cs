namespace SkyBots.Api.Jobs.Instructions;

public class WaitTicks : Instruction
{
    private readonly int _ticksCount;
    private int _remain;

    public WaitTicks(int count = 1)
    {
        Preconditions.Argument(count > 0, "Count of frames must be greater than 0.");
        _ticksCount = count;
    }

    protected override bool CheckReady()
    {
        if (_remain >= _ticksCount)
        {
            Reset();
            return true;
        }
        _remain++;
        return false;
    }

    protected override void OnCancelled()
    {
        
    }

    protected override void OnReset()
    {
        _remain = 0;
    }
}