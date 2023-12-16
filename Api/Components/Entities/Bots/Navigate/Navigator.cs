namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public abstract class Navigator : Component
{
    public abstract MoveTask Move(MoveArgs args);
}