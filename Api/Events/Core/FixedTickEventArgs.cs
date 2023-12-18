using Undefined.Events;

namespace SkyBots.Api.Events.Core;

public class FixedTickEventArgs : IEventArgs
{
    public float DeltaTime { get; }

    public FixedTickEventArgs(float deltaTime)
    {
        DeltaTime = deltaTime;
    }
}