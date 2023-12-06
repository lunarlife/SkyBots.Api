namespace SkyBots.Api.Bots;

public class BindResult
{
    
    public IBotHandle? Handle { get; }
    public BotBindingResultCode Code { get; }
    public BindResult(IBotHandle? handle, BotBindingResultCode code)
    {
        Handle = handle;
        Code = code;
    }

}