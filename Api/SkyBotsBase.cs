using SkyBots.Api.Worlds;

namespace SkyBots.Api;

public abstract class SkyBotsBase
{
    internal static SkyBotsBase Implementation { get; private set; }

    public abstract IIsland Island { get; }
    public abstract bool IsEnabled { get; }
    public abstract IDebug Debug { get; }
    public abstract IWorld World { get; }

    public SkyBotsBase()
    {
        Implementation = Implementation is null ? this : throw new Exception("Implementation already instanced.");
    }
}