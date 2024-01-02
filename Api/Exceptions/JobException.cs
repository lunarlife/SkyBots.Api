namespace SkyBots.Api.Exceptions;

public class JobException : Exception
{
    public JobException(string? message) : base(message)
    {
    }
}