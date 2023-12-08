namespace SkyBots.Api.Inventories;

public struct Enchantment
{
    public Enchantment(int level, EnchantmentType type)
    {
        Level = level;
        Type = type;
    }

    public EnchantmentType Type { get; }
    public int Level { get; }
}