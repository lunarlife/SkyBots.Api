using SkyBots.Api.Worlds.Data;

namespace SkyBots.Api.Components.Inventories;

public interface IChestInventory : IInventory<IContainer>, IStorageInventory, IBlockInventory;