using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Inventories;

namespace SkyBots.Api.Events.Inventories.SlotChange;

public class BotInventorySlotChangeEventArgs : StorageInventorySlotChangeEventArgs
{
    public Bot Bot { get; }

    public BotInventorySlotChangeEventArgs(IInventory inventory, int slot, ItemStack old, ItemStack @new, Bot bot) :
        base(inventory, slot, old, @new)
    {
        Bot = bot;
    }
}