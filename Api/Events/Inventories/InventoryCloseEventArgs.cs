using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Inventories;

namespace SkyBots.Api.Events.Inventories;

public class InventoryCloseEventArgs : InventoryEventArgs
{
    public Bot Bot { get; }

    public InventoryCloseEventArgs(Bot bot, IInventory inventory) : base(inventory)
    {
        Bot = bot;
    }
}