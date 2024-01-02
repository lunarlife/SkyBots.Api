using SkyBots.Api.Jobs.Instructions;

namespace SkyBots.Api.Components.StateMachines;

public delegate IEnumerable<IInstruction?> StateInstruction<T>(IStateContext<T> context) where T : Enum;

public interface IStateContextBuilder<T> where T : Enum
{
    public IStateContextBuilder<T> Where(T value, StateInstruction<T> instruction);
    public IStateContext<T> Build(T initialState);
}