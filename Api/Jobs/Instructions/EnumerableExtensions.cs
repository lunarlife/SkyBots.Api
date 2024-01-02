namespace SkyBots.Api.Jobs.Instructions;

public static class EnumerableExtensions
{
    public static IInstruction AsInstruction(this IEnumerable<IInstruction?> enumerable) => new WaitNewJob(enumerable);
}