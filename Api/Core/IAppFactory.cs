using SkyBots.Api.Components.StateMachines;

namespace SkyBots.Api.Core;

public interface IAppFactory
{
    public IStateContextBuilder<T> GetStateContextEnumBuilder<T>() where T : Enum;
}