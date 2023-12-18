using SkyBots.Api.Components.Entities.Bots.TaskMachine;
using SkyBots.Api.Events.Bots;

namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public class BotNavigateCompletedEventArgs : TaskBotEventArgs
{
    public BotNavigateResult Result { get; }

    public BotNavigateCompletedEventArgs(BotNavigateResult result, Bot bot, SkyTask task) : base(bot, task)
    {
        Result = result;
    }
}