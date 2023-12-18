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
    public Block GetBlockAt(Vector3<int> position);
    public Block GetBlockAt(int x, int y, int z);
    public bool TryGetBlockAt(Vector3<int> position, out Block block);
    public bool TryGetBlockAt(int x, int y, int z, out Block block);

    public IChunk GetChunkAt(int x, int y);
    public IChunk GetChunkAt(Vector2<int> position);
    public bool TryGetChunkAt(int x, int y, out IChunk? chunk);
    public bool TryGetChunkAt(Vector2<int> position, out IChunk? chunk);

    public Task WaitForLoad();

    public static Vector2<int> ToChunkPosition(float x, float z) =>
        new((int)Math.Floor((x + 8) / CHUNK_SIZE), (int)Math.Floor((z + 8) / CHUNK_SIZE));

    public static Vector2<int> ToChunkPosition(Vector2<float> position) =>
        ToChunkPosition(position.X, position.Y); 


    public static Vector2<int> ToChunkBlockPosition(float x, float z) =>
        new((int)Math.Floor((x) % CHUNK_SIZE), (int)Math.Floor((z) % CHUNK_SIZE));

    public static Vector3<int> ToChunkBlockPosition(float x, float y, float z) =>
        new((int)Math.Floor((x) % CHUNK_SIZE), (int)y, (int)Math.Floor((z) % CHUNK_SIZE));

    public static Vector2<int> ToChunkBlockPosition(Vector2<float> position) =>
        ToChunkBlockPosition(position.X, position.Y);

    public static Vector3<int> ToChunkBlockPosition(Vector3<float> position) =>
        ToChunkBlockPosition(position.X, position.Y, position.Z);

    public static Vector3<int> ToChunkBlockPosition(Vector3<int> position) =>
        ToChunkBlockPosition(position.X, position.Y, position.Z);
}