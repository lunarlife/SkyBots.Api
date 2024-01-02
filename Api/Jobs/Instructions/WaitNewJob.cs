namespace SkyBots.Api.Jobs.Instructions;

internal class WaitNewJob : Instruction
{
    private readonly IEnumerable<IInstruction?> _instructions;
    private IEnumerator<IInstruction?>? _enumerator;

    public WaitNewJob(IEnumerable<IInstruction?> instructions)
    {
        _instructions = instructions;
    }

    protected override bool IsReady()
    {
        if (_enumerator == null)
        {
            _enumerator = _instructions.GetEnumerator();
            if (!_enumerator.MoveNext()) return true;
        }

        var current = _enumerator.Current;
        if (current is null)
            return !_enumerator.MoveNext();
        if (current.Update()) return !_enumerator.MoveNext();
        return false;
    }

    protected override void OnCancel()
    {
        _enumerator?.Current?.Cancel();
    }

    protected override void OnReset() => _enumerator = _instructions.GetEnumerator();
}