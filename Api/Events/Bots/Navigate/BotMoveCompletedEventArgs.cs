using SkyBots.Api.Components.Entities.Bots.Internal.Navigate;
using SkyBots.Api.Components.Entities.Bots.Internal.TaskMachine;
using SkyBots.Api.Entities;
using SkyBots.Api.Events.Tasks;

namespace SkyBots.Api.Events.Bots.Navigate;

public class BotMoveCompletedEventArgs : ITaskCompletedEventArgs
{
    public BotMoveResult Result { get; }
    public IEntity Bot { get; }

    public SkyTask Task { get; }

    public BotMoveCompletedEventArgs(BotMoveResult result, IEntity bot, SkyTask task)
    {
        Result = result;
        Bot = bot;
        Task = task;
    }
}