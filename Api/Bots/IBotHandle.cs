using SkyBots.Api.Plugins;

namespace SkyBots.Api.Bots;

public interface IBotHandle
{
    public IEnumerable<T> GetPlugins<T>() where T : IBotPlugin;

    public void Unbind();
}