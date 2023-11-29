namespace SkyBots.Api.Bots;
public abstract partial class BotHook
{
    public IBot Bot { get; }
    public void Activate()
    {
        Bot.ActivateHook(this);
    }
}