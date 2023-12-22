namespace SkyBots.Api.Jobs.Instructions;

public class WaitBool : IInstruction
{
    private readonly Func<bool> _func;

    public WaitBool(Func<bool> func)
    {
        _func = func;
    }

    public bool IsReady() => _func();

    public void Reset()
    {
    }
}