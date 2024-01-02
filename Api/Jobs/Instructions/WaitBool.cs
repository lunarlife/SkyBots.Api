namespace SkyBots.Api.Jobs.Instructions;

public class WaitBool : Instruction
{
    private readonly Func<bool> _func;

    public WaitBool(Func<bool> func)
    {
        _func = func;
    }

    protected override bool IsReady() => _func();

    protected override void OnCancel()
    {
    }

    protected override void OnReset()
    {
    }
}