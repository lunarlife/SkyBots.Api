using SkyBotsApi.Bots;
using SkyBotsApi.Math;

namespace SkyBotsApi;

public interface IIsland
{
    public IBot InitBot(BotInitArgs args);
    public BotId[] GetAvailableBots();
    public Vector2<int> Size { get; }
}