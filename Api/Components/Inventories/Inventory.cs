using SkyBots.Api.Inventories;

namespace SkyBots.Api.Components.Inventories;

public abstract class Inventory : Component
{
    public abstract int Size { get; }
    public abstract int Width { get; }
    public abstract int Height { get; }
    public abstract int ActiveSlot { get; }

    public abstract ItemStack this[int x, int y] { get; }
    public abstract ItemStack this[int slot] { get; }
}