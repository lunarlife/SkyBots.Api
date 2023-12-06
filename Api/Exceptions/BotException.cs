using SkyBots.Api.Bots;

namespace SkyBots.Api.Exceptions;

public class BotException : Exception
{
    public BotException(string? message) : base(message)
    {
    }
}

public class BotUnbindedException : BotException
{
    public BotUnbindedException(Bot bot) : base($"Bot with id {bot.Id} is unbinded.")
    {
    }
}