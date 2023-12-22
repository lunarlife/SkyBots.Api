namespace SkyBots.Api.Jobs.Instructions;

public class WaitNewJob : IInstruction
{
    private readonly IEnumerable<IInstruction?> _instructions;
    private IEnumerator<IInstruction?>? _enumerator;

    public WaitNewJob(IEnumerable<IInstruction?> instructions)
    {
        _instructions = instructions;
    }

    public bool IsReady()
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

    public void Reset()
    {
        _enumerator = _instructions.GetEnumerator();
    }
}