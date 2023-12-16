namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public enum BotMoveResult : sbyte
{
    Invalid,
    CompletedAdvance,
    Completed,
    TargetLost,

    //CLIENT
    Cancelled
}