namespace SkyBots.Api.Bots;

public interface IBotsManager
{
    public Task<BindResult> InitHandle(BotInitArgs args);
}