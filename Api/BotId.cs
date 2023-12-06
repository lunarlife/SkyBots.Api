namespace SkyBots.Api;

public readonly struct BotId : IEquatable<BotId>
{
    private readonly sbyte _id;

    public BotId(int id) => _id = (sbyte)id;

    public static implicit operator BotId(int value) => new(value);

    public static bool operator ==(BotId left, BotId right) => left._id == right._id;
    public static bool operator !=(BotId left, BotId right) => !(left == right);
    public bool Equals(BotId other) => _id == other._id;

    public override bool Equals(object? obj) => obj is BotId other && Equals(other);

    public override int GetHashCode() => _id.GetHashCode();
}