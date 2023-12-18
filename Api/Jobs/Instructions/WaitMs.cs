using SkyBots.Api.Core;

namespace SkyBots.Api.Jobs.Instructions;

public sealed class WaitMs : IInstruction
{
    private readonly float _ms;
    private double _time;

    public WaitMs(int ms)
    {
        _ms = ms;
    }

    public bool IsReady()
    {
        _time += Time.DeltaTime;
        var ready = _time >= _ms / 1000d;
        if (ready) _time = 0;
        return ready;
    }
}