namespace SkyBotsApi;

public abstract class SkyBots
{
    internal static SkyBots Implementation { get; private set; }
    
    public abstract IPluginManager PluginManager { get; }
    
    public SkyBots() => Implementation = Implementation is null ? this : throw new Exception("Implementation already instanced.");
}