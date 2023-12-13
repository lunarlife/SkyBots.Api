using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.Internal.Navigate;
using SkyBots.Api.Components.Entities.Bots.Internal.TaskMachine;

namespace SkyBots.Api.Events.Bots.Navigate;

public class BotMoveCompletedEventArgs : BotEventArgs
{
    public BotMoveResult Result { get; }

    public BotMoveCompletedEventArgs(BotMoveResult result, BotComponent bot, SkyTask task) : base(bot, task)
    {
        Result = result;
    }
}