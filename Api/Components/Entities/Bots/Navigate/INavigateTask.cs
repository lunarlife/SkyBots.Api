using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public interface INavigateTask : ISkyTask<INavigateTask>, ISkyTaskCancellable
{
    public Vector3<float> Target { get; }
    public bool Sprint { get; }
    public BotNavigateResult Result { get; }
}