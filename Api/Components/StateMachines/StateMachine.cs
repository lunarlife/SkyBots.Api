namespace SkyBots.Api.Components.StateMachines;

public abstract class StateMachine : Component
{
    public abstract IStateContext? Context { get; set; }
}