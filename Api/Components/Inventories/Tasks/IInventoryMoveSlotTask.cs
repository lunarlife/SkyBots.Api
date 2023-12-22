using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Entities.Bots.TaskMachine;

namespace SkyBots.Api.Components.Inventories.Tasks;

public interface IInventoryMoveSlotTask : ISkyTask<IInventoryMoveSlotTask>
{
    public IInventory SourceInventory { get; }
    public IInventory DestinationInventory { get; }
    public int SourceSlot { get; }
    public int DestinationSlot { get; }
    public int Count { get; }
    public ItemStack SourceOld { get; }
    public ItemStack SourceNeu { get; }
    public ItemStack DestinationOld { get; }
    public ItemStack DestinationNeu { get; }
    public InventoryMoveResult Result { get; }
    
}