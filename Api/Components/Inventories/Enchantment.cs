namespace SkyBots.Api.Components.Inventories;

public struct Enchantment
{
    private int _level;

    public Enchantment(EnchantmentType type, int level)
    {
        Preconditions.Range(level, 1, type.MaxLevel);
        Level = level;
        Type = type;
    }

    public EnchantmentType Type { get; set; }

    public int Level
    {
        readonly get => _level;
        set
        {
            Preconditions.Min(value, 1);
            _level = value;
        }
    }

    public static bool operator ==(Enchantment left, Enchantment right) =>
        left.Type == right.Type && left.Level == right.Level;

    public static bool operator !=(Enchantment left, Enchantment right) => !(left == right);
    public bool Equals(Enchantment other) => Type.Equals(other.Type) && Level == other.Level;

    public override bool Equals(object? obj) => obj is Enchantment other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Type, Level);
}