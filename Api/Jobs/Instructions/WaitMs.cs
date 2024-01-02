using SkyBots.Api.Core;

namespace SkyBots.Api.Jobs.Instructions;

public sealed class WaitMs : Instruction
{
    private readonly float _ms;
    private double _time;

    public WaitMs(int ms)
    {
        _ms = ms;
    }

    protected override bool IsReady()
    {
        _time += Time.DeltaTime;
        var ready = _time >= _ms / 1000d;
        if (ready) Reset();

        return ready;
    }

    protected override void OnCancel()
    {
    }

    protected override void OnReset() => _time = 0;
}