using SkyBots.Api.Inventories;

namespace SkyBots.Api.Events.Inventories.SlotChange;

public abstract class InventorySlotChangeEventArgs : InventoryEventArgs
{
    public int Slot { get; }
    public ItemStack Old { get; }
    public ItemStack New { get; }

    public InventorySlotChangeEventArgs(IInventory inventory, int slot, ItemStack old, ItemStack @new) : base(inventory)
    {
        Slot = slot;
        Old = old;
        New = @new;
    }
}