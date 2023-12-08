namespace SkyBots.Api;

public abstract class SkyBotsBase
{
    internal static SkyBotsBase Implementation { get; private set; }
    
    public abstract IIsland Island { get; }
    public abstract bool IsEnabled { get;  }

    public SkyBotsBase()
    {
        Implementation = Implementation is null ? this : throw new Exception("Implementation already instanced.");
    }
}