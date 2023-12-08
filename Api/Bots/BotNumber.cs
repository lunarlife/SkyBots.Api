namespace SkyBots.Api.Bots;

public readonly struct BotNumber : IEquatable<BotNumber>
{
    private readonly sbyte _id;

    public BotNumber(int id) => _id = (sbyte)id;

    public static implicit operator BotNumber(int value) => new(value);

    public static bool operator ==(BotNumber left, BotNumber right) => left._id == right._id;
    public static bool operator !=(BotNumber left, BotNumber right) => !(left == right);
    public bool Equals(BotNumber other) => _id == other._id;

    public override bool Equals(object? obj) => obj is BotNumber other && Equals(other);

    public override int GetHashCode() => _id.GetHashCode();
    public override string ToString() => _id.ToString();
}