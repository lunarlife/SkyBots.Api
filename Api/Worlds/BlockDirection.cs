using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Worlds;

public readonly struct BlockDirection
{
    private const int DIRECTION_COUNT = 7;
    private static readonly BlockDirection[] DirectionsArray = new BlockDirection[DIRECTION_COUNT];

    public static IReadOnlyList<BlockDirection> Directions => DirectionsArray.AsReadOnly();
    public Vector3<int> Offset { get; }
    public int Id { get; }

    private BlockDirection(int id, int xOffset, int yOffset, int zOffset)
    {
        Offset = new Vector3<int>(xOffset, yOffset, zOffset);
        Id = id;
    }

    public static BlockDirection FromId(int id)
    {
        Preconditions.Range(id, DIRECTION_COUNT - 1);
        return DirectionsArray[id];
    }

    public static readonly BlockDirection SELF = new(0, 0, 0, 0);
    public static readonly BlockDirection NORTH = new(1, 0, 0, -1);
    public static readonly BlockDirection EAST = new(2, 1, 0, 0);
    public static readonly BlockDirection SOUTH = new(3, 0, 0, 1);
    public static readonly BlockDirection WEST = new(4, -1, 0, 0);
    public static readonly BlockDirection UP = new(5, 0, 1, 0);
    public static readonly BlockDirection DOWN = new(6, 0, -1, 0);
}