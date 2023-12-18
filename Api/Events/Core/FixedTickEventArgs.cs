using Undefined.Events;

namespace SkyBots.Api.Events.Core;

public class FixedTickEventArgs : IEventArgs
{
    public FixedTickEventArgs(float deltaTime)
    {
        DeltaTime = deltaTime;
    }

    public float DeltaTime { get; }
}