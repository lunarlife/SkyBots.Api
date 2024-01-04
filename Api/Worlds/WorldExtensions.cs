using SkyBots.Api.Components.Entities;
using SkyBots.Api.Components.Entities.Bots;
using SkyBots.Api.Entities;
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Worlds;

public static class WorldExtensions
{
    public static bool FindBlockAround(this IEntity entity, Vector3<int> size, Material material, out IBlock? block) =>
        entity.FindBlockAround(App.World, size, material, out block);

    public static bool FindBlockAround(this Bot bot, Vector3<int> size, Material material, out IBlock? block) =>
        bot.Entity.FindBlockAround(App.World, size, material, out block);

    public static bool FindBlockAround(this IEntity entity, IWorld world, Vector3<int> size, Material material,
        out IBlock? block) => entity.Transform.FindBlockAround(world, size, material, out block);

    public static bool FindBlockAround(this Transform transform, IWorld world, Vector3<int> size, Material material,
        out IBlock? block)
    {
        var area = new Cube<int>((Vector3<int>)transform.Position - size, (Vector3<int>)transform.Position + size);
        return world.FindBlock(area, material, out block);
    }

    public static bool FindBlockAround(this IEntity entity, int size, Material material, out IBlock? block) =>
        entity.FindBlockAround(App.World, size, material, out block);

    public static bool FindBlockAround(this Bot bot, int size, Material material, out IBlock? block) =>
        bot.Entity.FindBlockAround(App.World, size, material, out block);

    public static bool FindBlockAround(this IEntity entity, IWorld world, int size, Material material,
        out IBlock? block) => entity.Transform.FindBlockAround(world, size, material, out block);

    public static bool FindBlockAround(this Transform transform, IWorld world, int size, Material material,
        out IBlock? block) =>
        transform.FindBlockAround(world, new Vector3<int>(size, size, size), material, out block);


    public static bool FindBlockAround(this IEntity entity, Vector3<int> size, Predicate<IBlock> predicate,
        out IBlock? block) =>
        entity.FindBlockAround(App.World, size, predicate, out block);

    public static bool FindBlockAround(this Bot bot, Vector3<int> size, Predicate<IBlock> predicate,
        out IBlock? block) =>
        bot.Entity.FindBlockAround(App.World, size, predicate, out block);

    public static bool FindBlockAround(this IEntity entity, IWorld world, Vector3<int> size,
        Predicate<IBlock> predicate,
        out IBlock? block) => entity.Transform.FindBlockAround(world, size, predicate, out block);

    public static bool FindBlockAround(this Transform transform, IWorld world, Vector3<int> size,
        Predicate<IBlock> predicate,
        out IBlock? block)
    {
        var area = new Cube<int>((Vector3<int>)transform.Position - size, (Vector3<int>)transform.Position + size);
        return world.FindBlock(area, predicate, out block);
    }


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
}