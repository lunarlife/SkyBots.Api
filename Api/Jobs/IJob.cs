using SkyBots.Api.Events;
using SkyBots.Api.Jobs.Instructions;
using Undefined.Events;

namespace SkyBots.Api.Jobs;

public interface IJob : IInstruction
{
    public IEventAccess<JobStatusChangedEventArgs> OnStatusChanged { get; }
}