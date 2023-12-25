namespace SkyBots.Api.Jobs.Instructions;

public class WaitNewJob : Instruction
{
    private readonly IEnumerable<IInstruction?> _instructions;
    private IEnumerator<IInstruction?>? _enumerator;
    
    public WaitNewJob(IEnumerable<IInstruction?> instructions)
    {
        _instructions = instructions;
    }

    protected override bool CheckReady()
    {
        _enumerator ??= _instructions.GetEnumerator();
        if (_enumerator.Current is { } instruction)
        {
            if (instruction.IsReady())
                if (!_enumerator.MoveNext())
                {
                    Reset();
                    return true;
                }
        }
        else if (!_enumerator.MoveNext())
        {
            Reset();
            return true;
        }

        return false;
    }

    protected override void OnCancelled()
    {
        _enumerator?.Current?.Cancel();
    }

    protected override void OnReset()
    {
        _enumerator = _instructions.GetEnumerator();
    }
}