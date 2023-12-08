namespace SkyBots.Api.Components;

public interface IPluginsHolder<T> where T : Component
{
    public IReadOnlyList<T> Plugins { get; }

    public TPlugin GetPlugin<TPlugin>() where TPlugin : T;
    public IEnumerable<TPlugin> GetPlugins<TPlugin>() where TPlugin : T;
}