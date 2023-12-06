using System.Diagnostics;
using SkyBots.Api.Exceptions;
using SkyBots.Api.Plugins;

namespace SkyBots.Api.Bots;

public class Bot
{
    private IBotHandle _handle;
    
    public bool IsBinded { get; private set; }
    public BotId Id { get; private set; }

    public async Task<BotBindingResultCode> Bind(BotInitArgs args)
    {
        var result = await SkyBots.Implementation.BotsManager.InitHandle(args);
        var code = result.Code;
        if (code != BotBindingResultCode.Success) return code;
        _handle = result.Handle!;
        Id = args.Id;
        IsBinded = true;
        return code;
    }

    public void Unbind()
    {
        CheckIsBinded();
    }

    [StackTraceHidden]
    private void CheckIsBinded()
    {
        if (!IsBinded) throw new BotUnbindedException(this);
    }
    public T GetPlugin<T>() where T : IBotPlugin => GetPlugins<T>().FirstOrDefault() ??
                                                    throw new PluginException(
                                                        $"Plugin with type {typeof(T).Name} not found.");

    public IEnumerable<T> GetPlugins<T>() where T : IBotPlugin => _handle.GetPlugins<T>();
}