using SkyBots.Api.Inventories;

namespace SkyBots.Api.Events.Inventories.SlotChange;

public class StorageInventorySlotChangeEventArgs : InventorySlotChangeEventArgs
{
    public StorageInventorySlotChangeEventArgs(IInventory inventory, int slot, ItemStack old, ItemStack @new) : base(
        inventory, slot, old, @new)
    {
    }
}