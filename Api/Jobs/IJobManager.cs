using SkyBots.Api.Jobs.Instructions;

namespace SkyBots.Api.Jobs;

public interface IJobManager
{
    public IJob ExecuteJob(IEnumerable<IInstruction?> job);
}