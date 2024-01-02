using SkyBots.Api.Inventories;
using Undefined.Events;

namespace SkyBots.Api.Events.Inventories;

public abstract class InventoryEventArgs : IEventArgs
{
    public IInventory Inventory { get; }

    public InventoryEventArgs(IInventory inventory)
    {
        Inventory = inventory;
    }
}