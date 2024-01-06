using SkyBots.Api.Events.World;
using SkyBots.Api.Mathematics;
using Undefined.Events;

namespace SkyBots.Api.Worlds;

public interface IWorld
{
    public const int CHUNK_SIZE = 16;
    public int MinHeight { get; }
    public int MaxHeight { get; }
    public int Size { get; }
    public bool IsLoaded { get; }
    public IEventAccess<WorldBlockChangeEventArgs> OnBlockChange { get; }
    public IBlock GetBlockAt(Vector3<int> position);
    public IBlock GetBlockAt(int x, int y, int z);
    public bool TryGetBlockAt(Vector3<int> position, out IBlock? block);
    public bool TryGetBlockAt(int x, int y, int z, out IBlock? block);

    public IChunk GetChunkAt(int x, int y);
    public IChunk GetChunkAt(Vector2<int> position);
    public bool TryGetChunkAt(int x, int y, out IChunk? chunk);
    public bool TryGetChunkAt(Vector2<int> position, out IChunk? chunk);

    public Task WaitForLoad();

    public bool FindBlock(out IBlock? block, params Material[] types);
    public bool FindBlock(Predicate<IBlock> predicate, out IBlock? block, bool cutEmptyAreas = true);

    public bool FindBlock(Cube<int> area, out IBlock? block, params Material[] types);
    public bool FindBlock(Cube<int> area, Predicate<IBlock> predicate, out IBlock? block, bool cutEmptyAreas = true);

    public static Vector2<int> ToChunkPosition(float x, float z) =>
        new((int)Math.Floor((x + 8) / CHUNK_SIZE), (int)Math.Floor((z + 8) / CHUNK_SIZE));

    public static Vector2<int> ToChunkPosition(Vector2<float> position) =>
        ToChunkPosition(position.X, position.Y);

    public Vector3<int> ToWorldPosition(Vector2<int> chunk, Vector3<int> position);

    public Vector3<int> ToWorldPosition(Vector2<int> chunk, int x, int y, int z);


    public static Vector2<int> ToBlockInChunkPosition(float x, float z) =>
        new((Mathe.Floor(x) + 8) & 15, (Mathe.Floor(z) + 8) & 15);

    public static Vector2<int> ToBlockInChunkPosition(int x, int z) =>
        new((x + 8) & 15, (z + 8) & 15);

    public static Vector3<int> ToBlockInChunkPosition(float x, float y, float z) =>
        new((Mathe.Floor(x) + 8) & 15, (int)y, (Mathe.Floor(z) + 8) & 15);

    public static Vector3<int> ToBlockInChunkPosition(int x, int y, int z) =>
        new((x + 8) & 15, y, (z + 8) & 15);

    public static Vector2<int> ToBlockInChunkPosition(Vector2<float> position) =>
        ToBlockInChunkPosition(position.X, position.Y);

    public static Vector3<int> ToBlockInChunkPosition(Vector3<float> position) =>
        ToBlockInChunkPosition(position.X, position.Y, position.Z);

    public static Vector3<int> ToBlockInChunkPosition(Vector3<int> position) =>
        ToBlockInChunkPosition(position.X, position.Y, position.Z);
}