using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Inventories;

public interface IInventoriesManager
{
    public IReadOnlyList<IInventory> Inventories { get; }
    public IInventory GetInventory(Vector3<int> position);
    public bool TryGetInventory(Vector3<int> position, out IInventory? inventory);
}