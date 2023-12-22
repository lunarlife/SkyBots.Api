using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public struct BotNavigateArgs
{
    public BotNavigateArgs()
    {
        Target = default;
        Sprint = false;
    }

    public Vector3<float> Target { get; init; }
    public bool Sprint { get; init; }
}