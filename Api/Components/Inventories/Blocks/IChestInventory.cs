using SkyBots.Api.Worlds.Data;

namespace SkyBots.Api.Components.Inventories.Blocks;

public interface IChestInventory : IInventory<IChest>, IStorageInventory, IBlockInventory, IFunctionalInventory;