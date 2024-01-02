using SkyBots.Api.Jobs;
using Undefined.Events;

namespace SkyBots.Api.Events;

public class JobStatusChangedEventArgs : IEventArgs
{
    public IJob Job { get; }

    public JobStatusChangedEventArgs(IJob job)
    {
        Job = job;
    }
}