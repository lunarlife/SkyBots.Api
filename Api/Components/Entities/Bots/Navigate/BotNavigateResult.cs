namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public enum BotNavigateResult : sbyte
{
    Invalid,
    CompletedAdvance,
    Completed,
    TargetLost,
    NotOnGround,
    Cancelled
}