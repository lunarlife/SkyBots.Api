namespace SkyBots.Api.Server;

public enum BotBindUpdateResult : sbyte
{
    Invalid,
    Binded,
    Unbinded,
    Created,
    Removed
}