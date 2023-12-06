using SkyBots.Api.Bots;

namespace SkyBots.Api;

public abstract class SkyBots
{
    internal static SkyBots Implementation { get; private set; }
    
    public abstract IPluginManager PluginManager { get; }
    public abstract IIsland Island { get; }
    public abstract IBotsManager BotsManager { get; }
    public abstract bool IsEnabled { get;  }

    public SkyBots()
    {
        Implementation = Implementation is null ? this : throw new Exception("Implementation already instanced.");
    }
}