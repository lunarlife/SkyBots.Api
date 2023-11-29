using SkyBots.Api.Bots;
using SkyBots.Api.Math;

namespace SkyBots.Api;

public interface IIsland
{
    public IBot InitBot(BotInitArgs args);
    public BotId[] GetAvailableBots();
    public Vector2<int> Size { get; }
}