using SkyBots.Api.Math;

namespace SkyBots.Api;

public interface IIsland
{
    public BotId[] GetAvailableBots();
    public Vector2<int> Size { get; }
}