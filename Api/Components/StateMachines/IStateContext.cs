using SkyBots.Api.Jobs.Instructions;

namespace SkyBots.Api.Components.StateMachines;

public interface IStateContext
{
    public StateMachine? Machine { get; }
    public bool IsExecuting { get; }
}

public interface IStateContext<T> : IStateContext where T : Enum
{
    public T State { get; }
    public IInstruction SwitchState(T state);
}