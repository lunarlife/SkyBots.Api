using SkyBots.Api.Components.Inventories;
using SkyBots.Api.Components.Inventories.Enums;

namespace SkyBots.Api.Events.Inventories.SlotChange;

public class FurnaceSlotChangeEventArgs : InventorySlotChangeEventArgs
{
    public new FurnaceSlot Slot { get; }
    public FurnaceSlotChangeEventArgs(IInventory inventory, int slot, ItemStack old, ItemStack @new) : base(inventory, slot, old, @new)
    {
        Slot = (FurnaceSlot)slot;
    }
}