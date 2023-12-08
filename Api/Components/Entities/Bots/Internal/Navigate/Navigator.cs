namespace SkyBots.Api.Components.Entities.Bots.Internal.Navigate;

public abstract class Navigator : Component
{
    public abstract MoveTask Move(MoveArgs args);
}