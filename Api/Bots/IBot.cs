namespace SkyBots.Api.Bots;

public interface IBot
{
    public T AddHook<T>() where T : BotHook, new();
    public void ActivateHook(BotHook hook);
}