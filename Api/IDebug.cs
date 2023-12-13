namespace SkyBots.Api;

public interface IDebug
{
    public void Info(object? message);
    public void Warning(object? message);
    public void Error(object? message);
}