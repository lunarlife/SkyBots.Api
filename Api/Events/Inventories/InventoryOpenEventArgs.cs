using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Inventories;

namespace SkyBots.Api.Events.Inventories;

public class InventoryOpenEventArgs : InventoryEventArgs
{
    public Bot Bot { get; }

    public InventoryOpenEventArgs(Bot bot, IInventory inventory) : base(inventory)
    {
        Bot = bot;
    }
}