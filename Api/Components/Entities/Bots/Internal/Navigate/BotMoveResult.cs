namespace SkyBots.Api.Components.Entities.Bots.Internal.Navigate;

public enum BotMoveResult : sbyte
{
    Invalid,
    CompletedAdvance,
    Completed,
    TargetLost,
    
    //CLIENT
    Cancelled
}