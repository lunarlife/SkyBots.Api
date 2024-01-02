using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Inventories.Tasks;

namespace SkyBots.Api.Inventories;

public interface IFunctionalInventory : IInventory
{
    public IInventoryMoveSlotTask Move(Bot bot, int source, int destination, int count);
    public IInventoryMoveSlotTask Take(Bot bot, int source, int destination, int count);
    public IInventoryMoveSlotTask Put(Bot bot, int source, int destination, int count);
}

public interface IFunctionalInventory<in T> : IFunctionalInventory where T : Enum
{
    public IInventoryMoveSlotTask Move(Bot bot, int source, T destination, int count) =>
        Move(bot, source, Convert.ToInt32(destination), count);

    public IInventoryMoveSlotTask Take(Bot bot, int source, T destination, int count) =>
        Take(bot, source, Convert.ToInt32(destination), count);

    public IInventoryMoveSlotTask Put(Bot bot, int source, T destination, int count) =>
        Put(bot, source, Convert.ToInt32(destination), count);
}