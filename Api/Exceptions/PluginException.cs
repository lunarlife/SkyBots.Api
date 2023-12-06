namespace SkyBots.Api.Exceptions;

public class PluginException : Exception
{
    public PluginException(string? message) : base(message)
    {
    }
}