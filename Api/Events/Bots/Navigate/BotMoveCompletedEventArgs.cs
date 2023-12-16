using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.Navigate;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Tasks;

namespace SkyBots.Api.Events.Bots.Navigate;

public class BotMoveCompletedEventArgs : BotEventArgs, ITaskCompletedEventArgs
{
    public BotMoveResult Result { get; }

    public BotMoveCompletedEventArgs(BotMoveResult result, BotComponent bot, SkyTask task) : base(bot, task)
    {
        Result = result;
    }
}