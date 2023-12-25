namespace SkyBots.Api.Jobs.Instructions;

public class WaitBool : Instruction
{
    private readonly Func<bool> _func;

    public WaitBool(Func<bool> func)
    {
        _func = func;
    }

    protected override bool CheckReady() => _func();

    protected override void OnCancelled()
    {
    }

    protected override void OnReset()
    {
    }

}