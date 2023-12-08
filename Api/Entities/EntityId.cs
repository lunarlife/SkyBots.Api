namespace SkyBots.Api.Entities;

public readonly struct EntityId : IEquatable<EntityId>
{
    private readonly int _id;

    public EntityId(int id) => _id = id;

    public static implicit operator EntityId(int value) => new(value);

    public static bool operator ==(EntityId left, EntityId right) => left._id == right._id;
    public static bool operator !=(EntityId left, EntityId right) => !(left == right);
    public bool Equals(EntityId other) => _id == other._id;

    public override bool Equals(object? obj) => obj is EntityId other && Equals(other);

    public override int GetHashCode() => _id.GetHashCode();
    public override string ToString() => _id.ToString();
}