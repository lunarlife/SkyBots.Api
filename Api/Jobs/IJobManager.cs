using SkyBots.Api.Jobs.Instructions;

namespace SkyBots.Api.Jobs;

public interface IJobManager
{
    public void ExecuteJob(IEnumerable<IInstruction> job);
}