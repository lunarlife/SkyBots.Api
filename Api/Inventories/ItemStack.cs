namespace SkyBots.Api.Inventories;

public struct ItemStack
{
    private readonly Enchantment[] _enchantments = [];
    public Material Material { get; set; }
    public int Count { get; }
    public IReadOnlyList<Enchantment> Enchantments => _enchantments.AsReadOnly();

    public ItemStack(Material material, int count, Enchantment[] enchantments)
    {
        Material = material;
        Count = count;
    }
}