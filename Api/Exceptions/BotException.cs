namespace SkyBots.Api.Exceptions;

public class BotException : Exception
{
    public BotException(string? message) : base(message)
    {
    }
}