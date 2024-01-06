using SkyBots.Api.Components.Entities;
using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Entities;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Worlds;

public static class WorldExtensions
{
    public static IBlock GetRelative(this IBlock block, BlockDirection direction) =>
        block.World.GetBlockAt(block.Position + direction.Offset);

    public static IBlock[] GetBlocksAround(this IBlock block)
    {
        var directions = BlockDirection.Directions;
        var blocks = new IBlock[directions.Count - 1];
        for (var i = 1; i < directions.Count; i++) blocks[i] = block.GetRelative(directions[i - 1]);
        return blocks;
    }

    public static bool IsOnlyAirAround(this IBlock block) => block.GetBlocksAround().All(b => b.Type == Material.AIR);

    public static bool FindBlockAround(this IEntity entity, Vector3<int> size, out IBlock? block,
        params Material[] types) =>
        entity.FindBlockAround(App.World, size, out block, types);

    public static bool FindBlockAround(this Bot bot, Vector3<int> size, out IBlock? block, params Material[] types) =>
        bot.Entity.FindBlockAround(App.World, size, out block, types);

    public static bool FindBlockAround(this IEntity entity, IWorld world, Vector3<int> size, out IBlock? block,
        params Material[] types) => entity.Transform.FindBlockAround(world, size, out block, types);

    public static bool FindBlockAround(this IEntity entity, int size, out IBlock? block, params Material[] types) =>
        entity.FindBlockAround(App.World, size, out block, types);

    public static bool FindBlockAround(this Bot bot, int size, out IBlock? block, params Material[] types) =>
        bot.Entity.FindBlockAround(App.World, size, out block, types);

    public static bool FindBlockAround(this IEntity entity, IWorld world, int size, out IBlock? block,
        params Material[] types) => entity.Transform.FindBlockAround(world, size, out block, types);

    public static bool FindBlockAround(this Transform transform, IWorld world, int size, out IBlock? block,
        params Material[] types) =>
        transform.FindBlockAround(world, new Vector3<int>(size, size, size), out block, types);

    public static bool FindBlockAround(this IEntity entity, Vector3<int> size, Predicate<IBlock> predicate,
        out IBlock? block) =>
        entity.FindBlockAround(App.World, size, predicate, out block);

    public static bool FindBlockAround(this Bot bot, Vector3<int> size, Predicate<IBlock> predicate,
        out IBlock? block) =>
        bot.Entity.FindBlockAround(App.World, size, predicate, out block);

    public static bool FindBlockAround(this IEntity entity, IWorld world, Vector3<int> size,
        Predicate<IBlock> predicate,
        out IBlock? block) => entity.Transform.FindBlockAround(world, size, predicate, out block);

    public static bool FindBlockAround(this IEntity entity, int size, Predicate<IBlock> predicate,
        out IBlock? block) =>
        entity.FindBlockAround(App.World, size, predicate, out block);

    public static bool FindBlockAround(this Bot bot, int size, Predicate<IBlock> predicate,
        out IBlock? block) =>
        bot.Entity.FindBlockAround(App.World, size, predicate, out block);

    public static bool FindBlockAround(this IEntity entity, IWorld world, int size,
        Predicate<IBlock> predicate,
        out IBlock? block) => entity.Transform.FindBlockAround(world, size, predicate, out block);

    public static bool FindBlockAround(this Transform transform, IWorld world, int size,
        Predicate<IBlock> predicate,
        out IBlock? block) =>
        transform.FindBlockAround(world, new Vector3<int>(size, size, size), predicate, out block);

    public static bool FindBlockAround(this Transform transform, IWorld world, Vector3<int> size,
        Predicate<IBlock> predicate,
        out IBlock? block)
    {
        var area = new Cube<int>((Vector3<int>)transform.Position - size, (Vector3<int>)transform.Position + size);
        return world.FindBlock(area, predicate, out block);
    }

    public static bool FindBlockAround(this Transform transform, IWorld world, Vector3<int> size, out IBlock? block,
        params Material[] types)
    {
        var area = new Cube<int>((Vector3<int>)transform.Position - size, (Vector3<int>)transform.Position + size);
        return world.FindBlock(area, out block, types);
    }
}