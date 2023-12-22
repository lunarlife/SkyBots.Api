using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Components.Inventories.Tasks;

namespace SkyBots.Api.Components.Inventories;

public interface IFunctionalInventory
{
    public IInventoryMoveSlotTask Move(Bot bot, InventoryTarget target, int source, int destination, int count);
}

public interface IFunctionalInventory<in T> : IFunctionalInventory where T : Enum
{
    public IInventoryMoveSlotTask Move(Bot bot, InventoryTarget target, int source, T destination, int count) =>
        Move(bot, target, source, Convert.ToInt32(destination), count); 
}