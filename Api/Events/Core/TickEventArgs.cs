using Undefined.Events;

namespace SkyBots.Api.Events.Core;

public class TickEventArgs : IEventArgs
{
    public float DeltaTime { get; }
    public TickEventArgs(float deltaTime)
    {
        DeltaTime = deltaTime;
    }

}