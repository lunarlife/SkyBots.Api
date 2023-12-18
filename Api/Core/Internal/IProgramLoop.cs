using SkyBots.Api.Events.Core;
using Undefined.Events;

namespace SkyBots.Api.Core.Internal;

public interface IProgramLoop
{
    public IEventAccess<TickEventArgs> OnTick { get; }
    public IEventAccess<FixedTickEventArgs> OnFixedTick { get; }
    public float DeltaTime { get; }
    public float FixedDeltaTime { get; }
    public int TargetTickRate { get; set; }
    public int TargetFixedTickRate { get; set; }
    public float TotalTime { get; }
}